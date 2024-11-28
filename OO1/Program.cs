// File: Program.cs
using OO1;

Console.WriteLine("hallo");
var birthdate = new DateTime(2014, 2, 1);
var myCat = new Cat(birthdate, "bla");
//using MyFirstCat;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyFirstCat
//{
//    class Cat
//    {
//        private string? _Color = null;
//        private DateTime _BirthDate;
//        private string name;

//        public string Color
//        {
//            get { return _Color; }
//            set
//            {
//                if (_Color == value) return;
//                _Color = value;
//            }
//        }

//        public string Name
//        {
//            get { return name; }
//            set
//            {
//                if (name == value) return;
//                name = value;
//            }
//        }

//        public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }

//        public Cat(DateTime birthdate, string color = "Nicht Verfügbar", string name1 = "Nicht Verfügbar")
//        {
//            _BirthDate = birthdate;
//            _Color = color;
//            name = name1;
//        }

//        public override string ToString()
//        {
//            return $"Name: {Name}, Alter: {Age} Jahre, Farbe: {Color}";
//        }
//    }

//    class Tierheim
//    {
//        private List<Cat> tiere = new List<Cat>();

//        public void AddAnimal(Cat cat)
//        {
//            tiere.Add(cat);
//            Console.WriteLine($"\nEs wurde die neue Katze {cat.Name} hinzugefügt!\n");
//        }

//        public void ShowAnimals()
//        {
//            int index = 1;
//            foreach (var cat in tiere)
//            {
//                Console.WriteLine($"\nKatze {index}: {cat.Name} | Farbe: {cat.Color} | Alter: {cat.Age}\n");
//                index++;
//            }
//        }
//    }
//}


//void tierConsole()
//{
//    Tierheim myTier = new Tierheim();
//    var besuch = true;
//    while (besuch)
//    {
//        Console.WriteLine("Willst du eine Katze hinzufügen (yes/no)");
//        string addCatRead = Console.ReadLine();
//        if (addCatRead == "yes" || addCatRead == "no")
//        {
//            if (addCatRead == "yes")
//            {
//                Console.WriteLine("Wann ist die Katze geboren? ");
//                string catBirthDate = Console.ReadLine();
//                if (DateTime.TryParse(catBirthDate, out DateTime dtBirth))
//                {
//                    Console.WriteLine("Welche Farbe hat die Katze?");
//                    string catColor = Console.ReadLine();
//                    Console.WriteLine("Wie heißt eure Katze?");
//                    string catName = Console.ReadLine();
//                    myTier.AddAnimal(new Cat(dtBirth, catColor, catName));
//                    Console.WriteLine("Hier ist die Liste mit allen Katzen:");
//                    myTier.ShowAnimals();
//                    Console.WriteLine("Willst du noch eine weitere Katze hinzufügen? yes/no");
//                    string addCatAgain = Console.ReadLine();
//                    if (addCatAgain == "yes")
//                    {
//                        tierConsole();
//                    }
//                    else if (addCatAgain == "no")
//                    {
//                        besuch = false;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Dies ist das falsche Format");
//                }
//            }
//            else if (addCatRead == "no")
//            {
//                besuch = false;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Das ist keine gültige Eingabe!");
//        }
//    }
//}

//tierConsole();


