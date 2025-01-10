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
            var person = new Person("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10));

            Assert.AreEqual("Amir Duratovic", person.Name);
            Assert.AreEqual("m�nnlich", person.Geschlecht);
            Assert.AreEqual(new DateTime(2008, 7, 10), person.Geburtsdatum);
        }
    }

    [TestFixture]
    public class Sch�lerTests
    {
        [Test]
        public void Sch�ler_CorrectlyInitialized()
        {
            var sch�ler = new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD");

            Assert.AreEqual("Vivien M�ller", sch�ler.Name);
            Assert.AreEqual("weiblich", sch�ler.Geschlecht);
            Assert.AreEqual(new DateTime(2006, 5, 15), sch�ler.Geburtsdatum);
            Assert.AreEqual("3bWi", sch�ler.Schulklasse);
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
            Assert.AreEqual(50, klassenraum.Gr��e);
            Assert.AreEqual(30, klassenraum.Pl�tze);
            Assert.IsTrue(klassenraum.HatCynap);
        }

        [Test]
        public void Klassenraum_AddSch�ler_Successfully()
        {
            var klassenraum = new Klassenraum("Raum 202", 50, 30, true);
            var sch�ler = new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI");

            var result = klassenraum.Hinzuf�gen(sch�ler);

            Assert.IsTrue(result);
            Assert.Contains(sch�ler, klassenraum.Sch�lerListe);
        }

        [Test]
        public void Klassenraum_AddSch�ler_FailsWhenFull()
        {
            var klassenraum = new Klassenraum("Raum 202", 50, 1, true);
            var sch�ler1 = new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI");
            var sch�ler2 = new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD");

            klassenraum.Hinzuf�gen(sch�ler1);
            var result = klassenraum.Hinzuf�gen(sch�ler2);

            Assert.IsFalse(result);
            Assert.AreEqual(1, klassenraum.Sch�lerListe.Count);
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
            Assert.IsEmpty(schule.Sch�lerListe);
            Assert.IsEmpty(schule.Klassenr�ume);
        }

        [Test]
        public void Schule_AddSch�ler_Successfully()
        {
            var schule = new Schule("HTL Dornbirn");
            var sch�ler = new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI");

            schule.Sch�lerHinzuf�gen(sch�ler);

            Assert.Contains(sch�ler, schule.Sch�lerListe);
        }

        [Test]
        public void Schule_AddKlassenraum_Successfully()
        {
            var schule = new Schule("HTL Dornbirn");
            var klassenraum = new Klassenraum("Raum 202", 50, 30, true);

            schule.KlassenraumHinzuf�gen(klassenraum);

            Assert.Contains(klassenraum, schule.Klassenr�ume);
        }

        [Test]
        public void Schule_AnzahlSch�ler_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));

            Assert.AreEqual(2, schule.Sch�lerListe.Count);
        }

        [Test]
        public void Schule_AnzahlNachGeschlecht_ReturnsCorrectCounts()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Saoud Walazi", "m�nnlich", new DateTime(2010, 8, 30), "3aWI"));

            var m�nnlich = schule.Sch�lerListe.Count(s => s.Geschlecht == "m�nnlich");
            var weiblich = schule.Sch�lerListe.Count(s => s.Geschlecht == "weiblich");

            Assert.AreEqual(2, m�nnlich);
            Assert.AreEqual(1, weiblich);
        }

        [Test]
        public void Schule_AnzahlKlassenr�ume_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.KlassenraumHinzuf�gen(new Klassenraum("Raum 202", 50, 30, true));
            schule.KlassenraumHinzuf�gen(new Klassenraum("Raum 203", 40, 25, false));

            Assert.AreEqual(2, schule.Klassenr�ume.Count);
        }

        [Test]
        public void Schule_Durchschnittsalter_ReturnsCorrectValue()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));

            var durchschnittsalter = schule.Sch�lerListe.Average(s => (DateTime.Now - s.Geburtsdatum).TotalDays / 365.25);

            Assert.IsTrue(durchschnittsalter > 17 && durchschnittsalter < 18); // Assuming the test runs in 2023
        }

        [Test]
        public void Schule_R�umeMitCynap_ReturnsCorrectRooms()
        {
            var schule = new Schule("HTL Dornbirn");
            var raum1 = new Klassenraum("Raum 202", 50, 30, true);
            var raum2 = new Klassenraum("Raum 203", 40, 25, false);
            var raum3 = new Klassenraum("Raum 204", 60, 35, true);

            schule.KlassenraumHinzuf�gen(raum1);
            schule.KlassenraumHinzuf�gen(raum2);
            schule.KlassenraumHinzuf�gen(raum3);

            var r�umeMitCynap = schule.Klassenr�ume.Where(r => r.HatCynap).ToList();

            Assert.AreEqual(2, r�umeMitCynap.Count);
            Assert.Contains(raum1, r�umeMitCynap);
            Assert.Contains(raum3, r�umeMitCynap);
        }

        [Test]
        public void Schule_AnzahlKlassen_ReturnsCorrectCount()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Saoud Walazi", "m�nnlich", new DateTime(2010, 8, 30), "3aWI"));

            var klassenAnzahl = schule.Sch�lerListe.Select(s => s.Schulklasse).Distinct().Count();
            Assert.AreEqual(2, klassenAnzahl);
        }

        [Test]
        public void Schule_KlassenMitSch�lerAnzahl_ReturnsCorrectData()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Saoud Walazi", "m�nnlich", new DateTime(2010, 8, 30), "3aWI"));

            var klassenMitAnzahl = schule.Sch�lerListe.GroupBy(s => s.Schulklasse)
                .Select(g => new { Klasse = g.Key, Anzahl = g.Count() }).ToList();

            Assert.AreEqual(2, klassenMitAnzahl.Count);
            Assert.IsTrue(klassenMitAnzahl.Any(k => k.Klasse == "3aWI" && k.Anzahl == 2));
            Assert.IsTrue(klassenMitAnzahl.Any(k => k.Klasse == "3aMD" && k.Anzahl == 1));
        }

        [Test]
        public void Schule_Frauenanteil_ReturnsCorrectPercentage()
        {
            var schule = new Schule("HTL Dornbirn");
            schule.Sch�lerHinzuf�gen(new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD"));
            schule.Sch�lerHinzuf�gen(new Sch�ler("Sirui Chen", "weiblich", new DateTime(2008, 8, 15), "3aWi"));

            var frauenanteil = schule.Sch�lerListe.Where(s => s.Schulklasse == "3aWi")
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
            var sch�ler1 = new Sch�ler("Amir Duratovic", "m�nnlich", new DateTime(2008, 7, 10), "3aWI");
            var sch�ler2 = new Sch�ler("Vivien M�ller", "weiblich", new DateTime(2006, 5, 15), "3aMD");
            schule.Sch�lerHinzuf�gen(sch�ler1);
            schule.Sch�lerHinzuf�gen(sch�ler2);

            var anzahlSch�ler = schule.Sch�lerListe.Count(s => s.Schulklasse == "3aWI");
            var passt = anzahlSch�ler <= raum.Pl�tze;

            Assert.IsTrue(passt);
        }
    }
}
