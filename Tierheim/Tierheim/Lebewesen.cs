using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Lebewesen
    {
        public DateTime _Birthdate { get; set; }
        public Lebewesen(DateTime birthdate)
        {
            _Birthdate = birthdate;
        }   
    }
}
