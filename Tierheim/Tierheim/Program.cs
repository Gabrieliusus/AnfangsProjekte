using Vererbung;

bool besuch = true;

void tierConsole()
{
    var myTier = new Tierheim();
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
                    string catColor = Console.ReadLine();
                    Console.WriteLine("Wie heißt das Tier?");
                    string catName = Console.ReadLine();
                    myTier.AddAnimal(new Cat(dtBirth, catColor, catName));
                    Console.WriteLine("Hier ist die Liste mit allen Katzen:");
                    myTier.ShowAnimals();
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