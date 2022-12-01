string[] sanat = new string[10];
int seuraava_index = 0;
int sanojen_maara = 0;

while (true)
{
    Console.Write("sana (lopeta lopettaa): ");
    string syote = Console.ReadLine();

    if (syote == "lopeta")
    {
        break;
    }

    // lisää taulukkoon
    sanat[seuraava_index] = syote;
    sanojen_maara++;

    if (seuraava_index == sanat.Length - 1)
    {
        break;
    }
    seuraava_index++;
}

Console.WriteLine($"Syötit {sanojen_maara} sanaa");

if (sanojen_maara > 0)
{
    Console.WriteLine("eka sana: " + sanat[0]);
    Console.WriteLine("viimeinen sana: " + sanat[sanojen_maara - 1]);
}

string lyhin = "";
int lyhin_pituus = int.MaxValue;

string pisin = "";
int pisin_pituus = 0;

for (int i = 0; i < sanojen_maara; i++)
{
    string sana = sanat[i];
    if (sana.Length < lyhin_pituus)
    {
        lyhin = sana;
        lyhin_pituus = sana.Length;
    }

    if (sana.Length > pisin_pituus)
    {
        pisin = sana;
        pisin_pituus = sana.Length;
    }
}

Console.WriteLine("Lyhin sana: " + lyhin);
Console.WriteLine("Pisin sana: " + pisin);