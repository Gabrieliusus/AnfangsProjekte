using System.Collections.Generic;

public class Stadt
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Person> Personen { get; set; } = new();
}
