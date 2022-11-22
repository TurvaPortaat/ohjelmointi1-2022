string[] juomat = { "maito", "vesi", "kahvi", "tee", "limsa" };

Console.WriteLine("Vaihtoehdot: ");

Console.Write("0: " + juomat[0] + ", ");
Console.Write("1: " + juomat[1] + ", ");
Console.Write("2: " + juomat[2] + ", ");
Console.Write("3: " + juomat[3] + ", ");
Console.WriteLine("4: " + juomat[4]);

Console.Write("Valintasi [0-4]: ");

string valinta = Console.ReadLine();
int valinta_int = int.Parse(valinta);

if (valinta_int > juomat.Length - 1 || valinta_int < 0)
{
    Console.WriteLine("Viallinen valinta");
}
else
{
    Console.WriteLine(juomat[valinta_int] + "! Hyvä valinta.");
}