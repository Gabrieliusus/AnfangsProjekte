// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, SWP!!");
string UserInput = " ";
while (true)
{
    UserInput = Console.ReadLine();
    Console.WriteLine(UserInput);
    if (UserInput == "beenden") {  break; }
}
