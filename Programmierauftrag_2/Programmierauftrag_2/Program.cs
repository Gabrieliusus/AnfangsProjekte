bool isTrue = true;

while (isTrue)
{
    Console.WriteLine("Geben Sie einen beliebigen Text ein:");
    string Input = Console.ReadLine();
    if (int.TryParse(Input, out int value))
    {
        Console.WriteLine(value + 5);
    }
    else
    {
        Console.WriteLine(Input);
    }
    if (Input == "Beenden" || Input == "beenden")
    {
        isTrue = false;
    }
}