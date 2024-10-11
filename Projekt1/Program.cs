using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie einen Wert ein:");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out bool boolValue))
        {
            Console.WriteLine("Input ist vom Typ: Bool");
            Console.WriteLine($"Initialisierte Variable: {boolValue}");
        }
        else if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine("Input ist vom Typ: Integer");
            Console.WriteLine($"Initialisierte Variable: {intValue}");
        }
        else if (double.TryParse(input, out double doubleValue))
        {
            Console.WriteLine("Input ist vom Typ: Double");
            Console.WriteLine($"Initialisierte Variable: {doubleValue}");
        }
        else if (DateTime.TryParse(input, out DateTime dateValue))
        {
            Console.WriteLine("Input ist vom Typ: Datum (DateTime)");
            Console.WriteLine($"Initialisierte Variable: {dateValue.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Der Input konnte nicht erkannt werden.");
        }
    }
}