// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, SWP!!");
string UserInput = " ";
while (true)
{
    UserInput = Console.ReadLine();
    Console.WriteLine(UserInput);
    if (UserInput == "beenden") {  break; }
}

int UserInputint = 0;
while (true)
{
    UserInputint = int.TryParse(Console.ReadLine());
    Console.WriteLine(UserInput);
    if (UserInputint == 0) { break; }
}