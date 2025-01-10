using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    public class Person
    {
        public string Name { get; set; }
        public string Geschlecht { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public Person(string name, string geschlecht, DateTime geburtsdatum)
        {
            Name = name;
            Geschlecht = geschlecht;
            Geburtsdatum = geburtsdatum;
        }

        public override string ToString() =>
            $"{Name}, {Geschlecht}, Geboren: {Geburtsdatum.ToShortDateString()}";
    }
}
