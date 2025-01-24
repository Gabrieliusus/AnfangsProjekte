using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
            Auto auto2 = new Auto(4, new DateTime(2018, 6, 15), 180, "Diesel");

            Werkstatt werkstatt = new Werkstatt();

            werkstatt.AutoInWerkstattStellen(auto1);
            werkstatt.AutoInWerkstattStellen(auto2);

            Console.WriteLine($"Anzahl Autos in der Werkstatt: {werkstatt.AnzahlAutosInWerkstatt()}");

            Console.WriteLine($"Durchschnittliches Alter der Autos in der Werkstatt: {werkstatt.DurchschnittlichesAlterDerAutosInMonaten()} Monate");

            werkstatt.AutoAusWerkstattNehmen(auto1);

            Console.WriteLine($"Anzahl Autos in der Werkstatt nach Entfernung: {werkstatt.AnzahlAutosInWerkstatt()}");
        }
    }

