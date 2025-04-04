using System;
using System.Collections.Generic;
using System.Linq;

public class Werkstatt
{
    private List<Auto> autosInWerkstatt;

    public Werkstatt()
    {
        autosInWerkstatt = new List<Auto>();
    }


    public void AutoInWerkstattStellen(Auto? auto)
    {
        if (auto == null)
        {
            throw new ArgumentNullException(nameof(auto), "Das Auto darf nicht null sein.");
        }

        if (autosInWerkstatt.Contains(auto))
        {
            throw new InvalidOperationException("Das Auto befindet sich bereits in der Werkstatt.");
        }

        autosInWerkstatt.Add(auto);
    }


    public void AutoAusWerkstattNehmen(Auto auto)
    {
        autosInWerkstatt.Remove(auto);
    }

    public int AnzahlAutosInWerkstatt()
    {
        return autosInWerkstatt.Count;
    }

    public double DurchschnittlichesAlterDerAutosInMonaten()
    {
        return autosInWerkstatt.Any()
            ? autosInWerkstatt.Average(auto => auto.AlterInMonaten())
            : 0;
    }
}