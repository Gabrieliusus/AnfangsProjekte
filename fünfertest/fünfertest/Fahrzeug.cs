using System;


public class Fahrzeug
{
    public int Sitzplaetze { get; private set; }
    public DateTime Fabrikationsdatum { get; private set; }
    public double MaxGeschwindigkeit { get; private set; }

    public Fahrzeug(int sitzplaetze, DateTime fabrikationsdatum, double maxGeschwindigkeit)
    {
        Sitzplaetze = sitzplaetze;
        Fabrikationsdatum = fabrikationsdatum;
        MaxGeschwindigkeit = maxGeschwindigkeit;
    }

    public int AlterInMonaten()
    {
        return (DateTime.Now.Year - Fabrikationsdatum.Year) * 12 + DateTime.Now.Month - Fabrikationsdatum.Month;
    }
}