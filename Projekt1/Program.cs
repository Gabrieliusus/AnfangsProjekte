using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein:");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine Mathematische Operation auszuwählen:");
            Console.WriteLine("1) Quadrat");
            Console.WriteLine("2) Wurzel");
            Console.WriteLine("3) Fakultät");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    int square = number * number;
                    Console.WriteLine($"Das Quadrat von {number} ist: {square}");
                    break;

                case "2":
                    double squareRoot = Math.Sqrt(number);
                    Console.WriteLine($"Die Wurzel von {number} ist: {squareRoot}");
                    break;

                case "3":
                    long fakultät = faculty(number);
                    Console.WriteLine($"Die Fakultät von {number} ist: {fakultät}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Zahl zwischen 1 und 3.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine natürliche Zahl ein.");
        }
    }

    // Methode zur Berechnung der Fakultät
    static long faculty(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
