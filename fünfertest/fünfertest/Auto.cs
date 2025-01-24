using System;

public class Auto : Fahrzeug
{
    public string Antriebsart { get; private set; }

    public Auto(int sitzplaetze, DateTime fabrikationsdatum, double maxGeschwindigkeit, string antriebsart)
        : base(sitzplaetze, fabrikationsdatum, maxGeschwindigkeit)
    {
        Antriebsart = antriebsart;
    }
}