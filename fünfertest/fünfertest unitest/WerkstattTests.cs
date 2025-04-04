using System;
using NUnit.Framework;

[TestFixture]
public class WerkstattTests
{
    [Test]
    public void AnzahlAutosInWerkstatt_CorrectlyCountsCars()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        var auto2 = new Auto(4, new DateTime(2018, 6, 15), 180, "Diesel");

        werkstatt.AutoInWerkstattStellen(auto1);
        werkstatt.AutoInWerkstattStellen(auto2);

        Assert.AreEqual(2, werkstatt.AnzahlAutosInWerkstatt());
    }

    [Test]
    public void DurchschnittlichesAlterDerAutosInMonaten_CorrectlyCalculatesAverage()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        var auto2 = new Auto(4, new DateTime(2018, 6, 15), 180, "Diesel");
        werkstatt.AutoInWerkstattStellen(auto1);
        werkstatt.AutoInWerkstattStellen(auto2);

        var durchschnittlichesAlter = werkstatt.DurchschnittlichesAlterDerAutosInMonaten();

        Assert.Greater(durchschnittlichesAlter, 0);
    }

    [Test]
    public void AutoAusWerkstattNehmen_RemovesCarCorrectly()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        werkstatt.AutoInWerkstattStellen(auto1);

        werkstatt.AutoAusWerkstattNehmen(auto1);

        Assert.AreEqual(0, werkstatt.AnzahlAutosInWerkstatt());
    }
    [Test]
    public void DurchschnittlichesAlterDerAutosInMonaten_ReturnsZeroForEmptyWorkshop()
    {
        var werkstatt = new Werkstatt();

        var durchschnittlichesAlter = werkstatt.DurchschnittlichesAlterDerAutosInMonaten();

        Assert.AreEqual(0, durchschnittlichesAlter);
    }
    [Test]
    public void AutoInWerkstattStellen_DoesNotAllowNull()
    {
        var werkstatt = new Werkstatt();

        Assert.Throws<ArgumentNullException>(() => werkstatt.AutoInWerkstattStellen(null));
    }
    [Test]
    public void AutoAusWerkstattNehmen_DoesNotThrowWhenCarNotInWorkshop()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");

        Assert.DoesNotThrow(() => werkstatt.AutoAusWerkstattNehmen(auto1));
    }
    [Test]
    public void AutoInWerkstattStellen_DoesNotAddDuplicateCars()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        werkstatt.AutoInWerkstattStellen(auto1);

        werkstatt.AutoInWerkstattStellen(auto1);

        Assert.AreEqual(1, werkstatt.AnzahlAutosInWerkstatt());
    }
    [Test]
    public void AutoAusWerkstattNehmen_AutonichtinWerkstatt()
    {
        var werkstatt = new Werkstatt();
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        werkstatt.AutoAusWerkstattNehmen(auto1);
    }
    [Test]
    public void AutoAlterinMonaten_Autoist()
    {
        var auto1 = new Auto(5, new DateTime(2020, 1, 1), 220, "Benzin");
        var alterinMonaten = auto1.AlterInMonaten();
        Assert.That(alterinMonaten == 60);
    }
}