using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Lebewesen
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }
        public Lebewesen(DateTime birthDate, string color, string name)
        {
            Color = color;
            BirthDate = birthDate;
            Name = name;
        }
    }
}