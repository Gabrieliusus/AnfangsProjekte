using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AppDbContext();

        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var stadt = new Stadt { Name = "Musterstadt" };
        stadt.Personen.Add(new Person { Name = "Emma", Alter = 30 });
        stadt.Personen.Add(new Person { Name = "Luca", Alter = 25 });

        db.Staedte.Add(stadt);
        db.SaveChanges();

        var alleStaedte = db.Staedte.Include(s => s.Personen).ToList();
        foreach (var s in alleStaedte)
        {
            Console.WriteLine($"Stadt: {s.Name}");
            foreach (var p in s.Personen)
            {
                Console.WriteLine($" - {p.Name}, {p.Alter} Jahre");
            }
        }
    }
}
