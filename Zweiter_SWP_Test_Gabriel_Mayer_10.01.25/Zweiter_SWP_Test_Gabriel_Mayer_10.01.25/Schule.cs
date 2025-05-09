using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zweiter_SWP_Test_Gabriel_Mayer_10._01._25
{
    public class Schule
    {
        public string Name { get; set; }
        public List<Schüler> SchülerListe { get; set; }
        public List<Klassenraum> Klassenräume { get; set; }

        public Schule(string name)
        {
            Name = name;
            SchülerListe = new List<Schüler>();
            Klassenräume = new List<Klassenraum>();
        }

        public void SchülerHinzufügen(Schüler schüler) => SchülerListe.Add(schüler);

        public void KlassenraumHinzufügen(Klassenraum klassenraum) => Klassenräume.Add(klassenraum);

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{Name}:");
            builder.AppendLine($"- {SchülerListe.Count} Schüler");
            builder.AppendLine($"- {Klassenräume.Count} Klassenräume");
            return builder.ToString();
        }
    }
}
