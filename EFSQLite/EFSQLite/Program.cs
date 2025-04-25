using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AppDbContext();
        {
            db.Database.Migrate();
            var stadt = new Stadt
            {
                Name = "Fedkirch",
                PLZ = "6800",
            };
            db.Staedte.Add(stadt);
            db.SaveChanges();

            var fk = db.Staedte.FirstOrDefault(s => s.Name == "Fedkirch");
            var pers = new Person { Name = "Maurice1", Alter = 17, Stadt = fk };
            db.Personen.Add(pers);
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
}

