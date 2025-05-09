using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    public class Schüler : Person
    {
        public string Schulklasse { get; set; }

        public Schüler(string name, string geschlecht, DateTime geburtsdatum, string schulklasse)
            : base(name, geschlecht, geburtsdatum)
        {
            Schulklasse = schulklasse;
        }

        public override string ToString() =>
            $"{base.ToString()}, Klasse: {Schulklasse}";
    }
}
