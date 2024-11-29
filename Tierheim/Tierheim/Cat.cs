using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vererbung;

namespace Vererbung
{

    class Cat : Animal
    {
        public string setColor { get; set; }
       
        public int setAge { get { return (DateTime.Now.Year - _Birthdate.Year); } }
        public Cat(DateTime birthdate, string Color = "Nicht Verfügbar", string name = "Nicht Verfügbar") : base(name, birthdate) 
        {
            setColor = Color;
        }
        public override string ToString()
        {
            return $"Name :{Name}, Farbe: {setColor}, Alter: {setAge}";
        }
    }
}#
