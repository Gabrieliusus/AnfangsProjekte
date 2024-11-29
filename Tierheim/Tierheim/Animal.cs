using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Animal : Lebewesen
    {
        public string Name { get; set; }
        public Animal(string name, DateTime birthdate): base(birthdate)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
