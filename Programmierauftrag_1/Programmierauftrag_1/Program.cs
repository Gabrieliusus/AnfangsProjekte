bool isTrue = true;

while (isTrue)
{
    Console.WriteLine("Geben Sie einen beliebigen Text ein:");
    string Input = Console.ReadLine();
    Console.WriteLine(Input);
    if (Input == "Beenden" || Input == "beenden")
    {
        isTrue = false;
    }
}