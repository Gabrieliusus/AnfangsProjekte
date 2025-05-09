using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vererbung;

namespace Vererbung
{
    public abstract class Animal : Lebewesen
    {
        public int Beine { get; set; }
        public string TierTyp { get; set; }
        public Animal(string name, DateTime birthDate, string color, int beine, string tierTyp) : base(birthDate, color, name)
        {
            TierTyp = tierTyp;
            Beine = beine;
        }
        public abstract void gibTypischenLautVonDir();
        public override string ToString()
        {
            return Name;
        }
    }
}