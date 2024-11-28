bool isTrue = true;

while (isTrue)
{
    Console.WriteLine("Geben Sie einen beliebigen Text ein:");
    string Input = Console.ReadLine();
    if (int.TryParse(Input, out int value))
    {
        Console.WriteLine("Es ist ein Integer:" + value);
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