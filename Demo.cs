namespace Gasrulle.ThemeDemo;

/// <summary>
/// Represents a user in the system.
/// See <see cref="IRepository{T}"/> for data access patterns.
/// </summary>
[Serializable]
public class UserProfile
{
    public static int TotalUsers { get; private set; }
    public string Name { get; set; } = "Anonymous";
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
    public UserProfile(string name, UserRole role) { Name = name; Role = role; TotalUsers++; }
}

public enum UserRole { Guest = 0, Member = 1, Moderator = 2, Admin = 3 }

public readonly struct Coordinate(double latitude, double longitude)
{
    public double Latitude { get; } = latitude;
    public double Longitude { get; } = longitude;
    public double DistanceTo(Coordinate other) =>
        Math.Sqrt(Math.Pow(Latitude - other.Latitude, 2) + Math.Pow(Longitude - other.Longitude, 2));
}

public interface IRepository<T> where T : class
{
    Task<T?> FindAsync(int id);
    Task SaveAsync(T entity);
    event EventHandler<T> OnSaved;
}

public class UserRepo : IRepository<UserProfile>
{
    private static readonly Dictionary<int, UserProfile> _store = new();
    private int _nextId = 1;
    public event EventHandler<UserProfile>? OnSaved;

    public async Task<UserProfile?> FindAsync(int id)
    {
        await Task.Delay(10); // simulate I/O
        return _store.TryGetValue(id, out var user) ? user : null;
    }

    public async Task SaveAsync(UserProfile entity)
    {
        _store[_nextId++] = entity;
        await Task.CompletedTask;
        OnSaved?.Invoke(this, entity);
    }

    /// <param name="role">The role to filter by.</param>
    /// <param name="role">The role to filter by.</param>
    
    public async Task<List<UserProfile>> FindActiveAsync(UserRole role)
    {
        var all = _store.Values.ToList();
        return await Task.FromResult(
            all.Where(u => u.Role == role && u.IsActive).OrderBy(u => u.Name).ToList());
    }
}

public static class Extensions
{
    public static string Truncate(this string value, int max) =>
        string.IsNullOrEmpty(value) ? value : value.Length <= max ? value : value[..max] + "…";
}

public class Program
{
    private const double Radius = 6_371.0;
    private static readonly string[] Greetings = ["Hello", "Hej", "Bonjour"];

    public static async Task Main(string[] args)
    {
        var repo = new UserRepo();
        repo.OnSaved += (sender, u) => Console.WriteLine($"Saved: {u.Name}");

        var admin = new UserProfile("Alice", UserRole.Admin);
        var member = new UserProfile("Bob", UserRole.Member);
        await repo.SaveAsync(admin);
        await repo.SaveAsync(member);

        var admins = await repo.FindActiveAsync(UserRole.Admin);
        foreach (var user in admins)
        {
            string greeting = Greetings[new Random().Next(Greetings.Length)];
            Console.WriteLine($"{greeting}, {user.Name.Truncate(10)}!");
        }

        var origin = new Coordinate(59.3293, 18.0686);
        var target = new Coordinate(48.8566, 2.3522);
        double distance = origin.DistanceTo(target);

        if (distance > 5.0)
            Console.WriteLine($"Distance: {distance:F2} (far)");
        else if (distance > 0)
            Console.WriteLine($"Distance: {distance:F2} (near)");

        string desc = admin.Role switch
        {
            UserRole.Admin => "Full access",
            UserRole.Moderator => "Can moderate",
            UserRole.Member => "Standard",
            _ => "Limited"
        };

        try
        {
            int count = UserProfile.TotalUsers;
            Console.WriteLine($"{count} users — {desc}");
        }
        catch (Exception ex) when (ex is not OutOfMemoryException)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            throw;
        }
        finally { Console.WriteLine("Done."); }
    }
}
