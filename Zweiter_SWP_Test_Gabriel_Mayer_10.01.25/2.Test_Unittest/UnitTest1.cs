using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Zweiter_SWP_Test_Gabriel_Mayer_10._01._25;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Person_CorrectlyInitialized()
        {
            var person = new Person("Amir Duratovic", "männlich", new DateTime(2008, 7, 10));

            Assert.AreEqual("Amir Duratovic", person.Name);
            Assert.AreEqual("männlich", person.Geschlecht);
            Assert.AreEqual(new DateTime(2008, 7, 10), person.Geburtsdatum);
        }
    }

    [TestFixture]
    public class SchülerTests
    {
        [Test]
        public void Schüler_CorrectlyInitialized()
        {
            var schüler = new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD");

            Assert.AreEqual("Vivien Müller", schüler.Name);
            Assert.AreEqual("weiblich", schüler.Geschlecht);
            Assert.AreEqual(new DateTime(2006, 5, 15), schüler.Geburtsdatum);
            Assert.AreEqual("3bWi", schüler.Schulklasse);
        }
    }

    [TestFixture]
    public class KlassenraumTests
    {
        [Test]
        public void Klassenraum_CorrectlyInitialized()
        {
            var klassenraum = new Klassenraum("Raum 202", 50, 30, true);

            Assert.AreEqual("Raum 202", klassenraum.RaumName);
            Assert.AreEqual(50, klassenraum.Größe);
            Assert.AreEqual(30, klassenraum.Plätze);
            Assert.IsTrue(klassenraum.HatCynap);
        }

        [Test]
        public void Klassenraum_AddSchüler_Successfully()
        {
            var klassenraum = new Klassenraum("Raum 202", 50, 30, true);
            var schüler = new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI");

            var result = klassenraum.Hinzufügen(schüler);

            Assert.IsTrue(result);
            Assert.Contains(schüler, klassenraum.SchülerListe);
        }

        [Test]
        public void Klassenraum_AddSchüler_FailsWhenFull()
        {
            var klassenraum = new Klassenraum("Raum 202", 50, 1, true);
            var schüler1 = new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI");
            var schüler2 = new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD");

            klassenraum.Hinzufügen(schüler1);
            var result = klassenraum.Hinzufügen(schüler2);

            Assert.IsFalse(result);
            Assert.AreEqual(1, klassenraum.SchülerListe.Count);
        }
    }

    [TestFixture]
    public class SchuleTests
    {
        [Test]
        public void Schule_CorrectlyInitialized()
        {
            var schule = new Schule("HTL Dornbirn");

            Assert.AreEqual("HTL Dornbirn", schule.Name);
            Assert.IsEmpty(schule.SchülerListe);
            Assert.IsEmpty(schule.Klassenräume);
        }

        [Test]
        public void Schule_AddSchüler_Successfully()
        {
            var schule = new Schule("HTL Dornbirn");
            var schüler = new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI");

            schule.SchülerHinzufügen(schüler);

            Assert.Contains(schüler, schule.SchülerListe);
        }

        [Test]
        public void Schule_AddKlassenraum_Successfully()
        {
            var schule = new Schule("HTL Dornbirn");
            var klassenraum = new Klassenraum("Raum 202", 50, 30, true);

            schule.KlassenraumHinzufügen(klassenraum);

            Assert.Contains(klassenraum, schule.Klassenräume);
        }

        [Test]
        public void Schule_AnzahlSchüler_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));

            Assert.AreEqual(2, schule.SchülerListe.Count);
        }

        [Test]
        public void Schule_AnzahlNachGeschlecht_ReturnsCorrectCounts()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.SchülerHinzufügen(new Schüler("Saoud Walazi", "männlich", new DateTime(2010, 8, 30), "3aWI"));

            var männlich = schule.SchülerListe.Count(s => s.Geschlecht == "männlich");
            var weiblich = schule.SchülerListe.Count(s => s.Geschlecht == "weiblich");

            Assert.AreEqual(2, männlich);
            Assert.AreEqual(1, weiblich);
        }

        [Test]
        public void Schule_AnzahlKlassenräume_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.KlassenraumHinzufügen(new Klassenraum("Raum 202", 50, 30, true));
            schule.KlassenraumHinzufügen(new Klassenraum("Raum 203", 40, 25, false));

            Assert.AreEqual(2, schule.Klassenräume.Count);
        }

        [Test]
        public void Schule_Durchschnittsalter_ReturnsCorrectValue()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));

            var durchschnittsalter = schule.SchülerListe.Average(s => (DateTime.Now - s.Geburtsdatum).TotalDays / 365.25);

            Assert.IsTrue(durchschnittsalter > 17 && durchschnittsalter < 18); // Assuming the test runs in 2023
        }

        [Test]
        public void Schule_RäumeMitCynap_ReturnsCorrectRooms()
        {
            var schule = new Schule("HTL Dornbirn");
            var raum1 = new Klassenraum("Raum 202", 50, 30, true);
            var raum2 = new Klassenraum("Raum 203", 40, 25, false);
            var raum3 = new Klassenraum("Raum 204", 60, 35, true);

            schule.KlassenraumHinzufügen(raum1);
            schule.KlassenraumHinzufügen(raum2);
            schule.KlassenraumHinzufügen(raum3);

            var räumeMitCynap = schule.Klassenräume.Where(r => r.HatCynap).ToList();

            Assert.AreEqual(2, räumeMitCynap.Count);
            Assert.Contains(raum1, räumeMitCynap);
            Assert.Contains(raum3, räumeMitCynap);
        }

        [Test]
        public void Schule_AnzahlKlassen_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.SchülerHinzufügen(new Schüler("Saoud Walazi", "männlich", new DateTime(2010, 8, 30), "3aWI"));

            var klassenAnzahl = schule.SchülerListe.Select(s => s.Schulklasse).Distinct().Count();
            Assert.AreEqual(2, klassenAnzahl);
        }

        [Test]
        public void Schule_KlassenMitSchülerAnzahl_ReturnsCorrectData()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.SchülerHinzufügen(new Schüler("Saoud Walazi", "männlich", new DateTime(2010, 8, 30), "3aWI"));

            var klassenMitAnzahl = schule.SchülerListe.GroupBy(s => s.Schulklasse)
                .Select(g => new { Klasse = g.Key, Anzahl = g.Count() }).ToList();

            Assert.AreEqual(2, klassenMitAnzahl.Count);
            Assert.IsTrue(klassenMitAnzahl.Any(k => k.Klasse == "3aWI" && k.Anzahl == 2));
            Assert.IsTrue(klassenMitAnzahl.Any(k => k.Klasse == "3aMD" && k.Anzahl == 1));
        }

        [Test]
        public void Schule_Frauenanteil_ReturnsCorrectPercentage()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.SchülerHinzufügen(new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.SchülerHinzufügen(new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.SchülerHinzufügen(new Schüler("Sirui Chen", "weiblich", new DateTime(2008, 8, 15), "3aWi"));

            var frauenanteil = schule.SchülerListe.Where(s => s.Schulklasse == "3aWi")
                .GroupBy(s => s.Geschlecht).ToDictionary(g => g.Key, g => g.Count());

            var anteil = frauenanteil.ContainsKey("weiblich") ?
                (double)frauenanteil["weiblich"] / frauenanteil.Values.Sum() * 100 : 0;

            Assert.AreEqual(66.67, Math.Round(anteil, 2));
        }

        [Test]
        public void Schule_KlassePasstInRaum_ReturnsCorrectResult()

        {
            var schule = new Schule("HTL Dornbirn");
            var raum = new Klassenraum("Raum 101", 50, 2, true);
            var schüler1 = new Schüler("Amir Duratovic", "männlich", new DateTime(2008, 7, 10), "3aWI");
            var schüler2 = new Schüler("Vivien Müller", "weiblich", new DateTime(2006, 5, 15), "3aMD");
            schule.SchülerHinzufügen(schüler1);
            schule.SchülerHinzufügen(schüler2);

            var anzahlSchüler = schule.SchülerListe.Count(s => s.Schulklasse == "3aWI");
            var passt = anzahlSchüler <= raum.Plätze;

            Assert.IsTrue(passt);
        }
    }
}
