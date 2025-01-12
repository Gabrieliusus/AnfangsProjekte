using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    class Program
    {
        static void Main(string[] args)
        {
            var schule = new Schule("HTL Dornbirn");

            var schüler1 = new Schüler("Marco Bischof", "männlich", new DateTime(2010, 5, 14), "3aWi");
            var schüler2 = new Schüler("Katharina Eichhorner", "weiblich", new DateTime(2011, 7, 19), "4aMD");

            schule.SchülerHinzufügen(schüler1);
            schule.SchülerHinzufügen(schüler2);

            var klassenraum = new Klassenraum("Raum 247", 50, 30, true);

            klassenraum.Hinzufügen(schüler1);
            klassenraum.Hinzufügen(schüler2);

            schule.KlassenraumHinzufügen(klassenraum);

            Console.WriteLine(schule);
            Console.WriteLine(klassenraum);
        }
    }
}



//Was ist eine Klasse?
//Eine Klasse ist ein Bauplan, der definiert, wie ein Objekt aussieht und sich verhält.

//Was ist ein Objekt?
//Ein Objekt ist eine Instanz einer Klasse, die konkrete Werte für die definierten Eigenschaften enthält.

//Was ist ein Access Modifier?
//Ein Access Modifier steuert den Zugriff auf Mitglieder einer Klasse.

//Geben Sie 3 Access Modifier von C# an:
//public, private, protected.

//Was ist LINQ?
//LINQ ist eine Abfragesprache, mit der man Daten in C# einfach filtern und bearbeiten kann.
