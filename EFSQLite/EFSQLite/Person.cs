﻿public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Alter { get; set; }

    public int StadtId { get; set; }
    public Stadt Stadt { get; set; }
}
