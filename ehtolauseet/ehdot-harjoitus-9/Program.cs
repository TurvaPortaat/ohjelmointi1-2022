Console.Write("sana1: ");
string input1 = Console.ReadLine();

Console.Write("sana2: ");
string input2 = Console.ReadLine();

if ((input1 == "koulu" && input2 == "ohjelmointi") || (input1 == "ohjelmointi" && input2 == "koulu"))
{
    Console.WriteLine("Hienot sanat!");
}
else
{
    Console.WriteLine("Ei huonot sanat.");
}