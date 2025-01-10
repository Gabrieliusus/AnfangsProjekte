using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    public class Klassenraum
    {
        public string RaumName { get; set; }
        public int Größe { get; set; }
        public int Plätze { get; set; }
        public bool HatCynap { get; set; }
        public List<Schüler> SchülerListe { get; set; }

        public Klassenraum(string raumName, int größe, int plätze, bool hatCynap)
        {
            RaumName = raumName;
            Größe = größe;
            Plätze = plätze;
            HatCynap = hatCynap;
            SchülerListe = new List<Schüler>();
        }

        public bool Hinzufügen(Schüler schüler)
        {
            if (SchülerListe.Count >= Plätze) return false;
            SchülerListe.Add(schüler);
            return true;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{RaumName} ({Größe}m², {Plätze} Plätze, Cynap: {(HatCynap ? "Ja" : "Nein")})");
            builder.AppendLine("Schüler:");
            SchülerListe.ForEach(s => builder.AppendLine($"- {s.Name}"));
            return builder.ToString();
        }
    }
}

