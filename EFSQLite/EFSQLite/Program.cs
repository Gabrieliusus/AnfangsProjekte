using System;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AppDbContext();

        db.Database.EnsureCreated();

        db.Personen.Add(new Person { Name = "Emma", Alter = 30 });
        db.SaveChanges();

        Console.WriteLine("Person gespeichert!");
    }
}