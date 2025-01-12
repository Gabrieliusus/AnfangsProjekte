// See https://aka.ms/new-console-template for more information

using Vererbung;

bool besuch = true;
Tierheim myTier = new Tierheim();
Animal lastAnimal = null;

void tierConsole()
{
    while (besuch)
    {
        Console.WriteLine("Willst du ein Tier hinzufügen (yes/no)");
        string addCatRead = Console.ReadLine();
        if (addCatRead == "yes" || addCatRead == "no")
        {
            if (addCatRead == "yes")
            {
                Console.WriteLine("Wann ist das Tier geboren? ");
                string catBirthDate = Console.ReadLine();
                if (DateTime.TryParse(catBirthDate, out DateTime dtBirth))
                {
                    Console.WriteLine("Welche Farbe hat das Tier?");
                    string animalColor = Console.ReadLine();
                    Console.WriteLine("Wie heißt das Tier?");
                    string animalName = Console.ReadLine();
                    TierAbfrage();
                    string tierArt = Console.ReadLine();
                    if (int.TryParse(tierArt, out int tierArtAbfrage))
                    {
                        switch (tierArtAbfrage)
                        {
                            case 1:
                                Cat cat = new Cat(dtBirth, animalColor, animalName);
                                myTier.AddAnimal(cat);
                                lastAnimal = cat;
                                break;
                            case 2:
                                Dog dog = new Dog(dtBirth, animalColor, animalName);
                                myTier.AddAnimal(dog);
                                lastAnimal = dog;
                                break;
                        }
                        Console.WriteLine("Hier ist die Liste mit allen Tieren:");
                        myTier.ShowAnimals();
                        Console.WriteLine("Was willst du nun anstellen? \n1.Katze hinzufügen\n2.Geräusch vom Tier ausgeben\n3.Anzahl der Katzen ausgeben\n4.Anzahl der Hunde ausgeben\n5.Anzahl Tiere ausgeben\n6.Durchschnittsalter aller Tiere im Tierheim ausgeben");
                        string inputEnd = Console.ReadLine();
                        if (int.TryParse(inputEnd, out int dtEnd))
                        {
                            switch (dtEnd)
                            {
                                case 1:
                                    AddCat();
                                    break;
                                case 2:
                                    lastAnimal.gibTypischenLautVonDir();
                                    break;
                                case 3:
                                    Console.WriteLine($"Es sind {myTier.NumberOfCats} Katzen");
                                    break;
                                case 4:
                                    Console.WriteLine($"Es sind {myTier.NumberOfDogs} Katzen");
                                    break;
                                case 5:
                                    Console.WriteLine($"Es sind {myTier.NumberOfAnimals} Tiere");
                                    break;
                                case 6:
                                    Console.WriteLine($"Das Durchschnittsalter des Tierheimes beträgt {myTier.AvgAge}");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dies ist nicht möglich!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das ist keine gültige Zahl");
                    }
                }
                else
                {
                    Console.WriteLine("Dies ist das falsche Format");
                }
            }
            else if (addCatRead == "no")
            {
                besuch = false;
            }
        }
        else
        {
            Console.WriteLine("Das ist keine gültige Eingabe!");
        }
    }
}
tierConsole();
void AddCat()
{
    Console.WriteLine("Willst du noch eine weitere Katze hinzufügen? yes/no");
    string addCatAgain = Console.ReadLine();
    if (addCatAgain == "yes")
    {
        tierConsole();
    }
    else if (addCatAgain == "no")
    {
        besuch = false;
    }
}
void TierAbfrage()
{
    Console.WriteLine("Was für ein Tier ist es? \n 1.Cat \n 2.Dog");
}