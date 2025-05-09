using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vererbung;
namespace Vererbung
{
    public class Tierheim
    {
        public List<Animal> tiere = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            tiere.Add(animal);
            Console.WriteLine($"\nEs wurde neues {animal.TierTyp} {animal} hinzugefügt!\n");
        }
        public void ShowAnimals()
        {
            int index = 1;
            foreach (var tier in tiere)
            {
                Console.WriteLine(tier);
            }
        }
        public int NumberOfCats
        {
            get { return tiere.Where(a => a.GetType() == typeof(Cat)).Count(); }
        }

        public int NumberOfDogs
        {
            get { return tiere.Where(a => a.GetType() == typeof(Dog)).Count(); }
        }
        public int NumberOfAnimals
        {
            get
            {
                return tiere.Count;
            }
        }

        public float AvgAge
        {
            get
            {
                int age = 0;
                foreach (var tier in tiere)
                {
                    age += tier.Age;
                }
                float durchschnittsAlter = (float)age / (float)NumberOfAnimals;
                return durchschnittsAlter;

            }
        }


    }
}