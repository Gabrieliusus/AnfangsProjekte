bool isTrue = true;

while (isTrue)
{
    Console.WriteLine("Geben Sie einen beliebigen Text ein:");
    string Input = Console.ReadLine();
    if (int.TryParse(Input, out int value))
    {
        Console.WriteLine("Es ist ein Integer:" + value);
        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen: \n1) Quadrat\n2) Wurzel\n3) Fakultät ");
        string Multiplication = Console.ReadLine();
        if (int.TryParse(Multiplication, out int option))
        {
            switch (option) {
                case 1: Console.WriteLine(value * value); 
                    break;
                case 2: Console.WriteLine(Math.Sqrt(value)); 
                    break;
                case 3: 
                    int result = 1;
                    for (int i = 1; value >= i; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine(result);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 3 ein:");
        }
    }
    else if (bool.TryParse(Input, out bool boolvalue))
    {
        Console.WriteLine("Es ist ein Bool:" + boolvalue);
    }
    else if (double.TryParse(Input, out double doublevalue))
    {
        Console.WriteLine("Es ist ein double:" + doublevalue);
    }
    else if (DateTime.TryParse(Input, out DateTime DateTimeValue))
    {
        Console.WriteLine("Es ist eine DateTime:" + DateTimeValue);
    }
    else
    {
        Console.WriteLine("Es ist ein String:" + Input);
    }
    if (Input == "Beenden" || Input == "beenden")
    {
        isTrue = false;
    }
}