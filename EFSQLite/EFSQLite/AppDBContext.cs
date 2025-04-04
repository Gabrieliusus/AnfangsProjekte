using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Person> Personen { get; set; }
    public DbSet<Stadt> Staedte { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=meineDatenbank.db");
    }
}
