using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Seeders;

public class DataSeeder
{
    private readonly IEnumerable<ISeeder> _seeders;

    public DataSeeder(IEnumerable<ISeeder> seeders)
    {
        _seeders = seeders;
    }

    public void Seed()
    {
        foreach (var seeder in _seeders)
        {
            seeder.Seed();
        }
    }
}
