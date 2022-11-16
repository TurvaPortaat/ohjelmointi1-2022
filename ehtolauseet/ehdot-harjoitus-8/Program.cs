Console.Write("Valitse joko a tai b: ");
string input = Console.ReadLine();

if (input == "a")
{
    Console.WriteLine("hieno valinta");
}
else if (input == "b")
{
    Console.WriteLine("loistava valinta");
}
else
{
    Console.WriteLine("virheellinen syöte!");
}