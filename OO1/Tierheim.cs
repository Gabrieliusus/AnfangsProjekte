using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tierheim
    {
        private List<Cat> tiere = new List<Cat>();

        public void AddAnimal(Cat cat)
        {
            tiere.Add(cat);
            Console.WriteLine($"\nEs wurde die neue Katze {cat.Name} hinzugefügt!\n");
        }

        public void ShowAnimals()
        {
            int index = 1;
            foreach (var cat in tiere)
            {
                Console.WriteLine($"\nKatze {index}: {cat.Name} | Farbe: {cat.Color} | Alter: {cat.Age}\n");
                index++;
            }
        }
         }