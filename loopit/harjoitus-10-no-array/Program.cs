int sanojen_maara = 0;

string lyhin = "";
// alkuarvo lyhimmälle sanalla on joku iso arvo
// tässä tapauksessa suurin mahdollisin arvo, joka int-tyyppiin voidaan laittaa
int lyhin_pituus = int.MaxValue;

string pisin = "";
int pisin_pituus = 0;

string eka_sana = "";
string vika_sana = "";

while (true)
{
    Console.Write("sana (lopeta lopettaa): ");
    string syote = Console.ReadLine();

    if (syote == "lopeta")
    {
        break;
    }

    // jos ensimmäinen sana
    if (eka_sana == "")
    {
        eka_sana = syote;
    }

    // mikä tahansa syötetty sana saattaa jäädä viimeiseksi
    vika_sana = syote;

    sanojen_maara++;

    // syötetty sana on lyhyempi kuin tunnetuin lyhyin sana
    if (syote.Length < lyhin_pituus)
    {
        lyhin = syote;
        lyhin_pituus = syote.Length;
    }

    // syötetty sana on pidempi kuin tunnetuin pisin sana
    if (syote.Length > pisin_pituus)
    {
        pisin = syote;
        pisin_pituus = syote.Length;
    }

    if (sanojen_maara == 10)
    {
        break;
    }
}

Console.WriteLine($"Syötit {sanojen_maara} sanaa");

// jos sanoja on syötetty, niin tulostetaan tilastot
if (sanojen_maara > 0)
{
    Console.WriteLine("eka sana: " + eka_sana);
    Console.WriteLine("viimeinen sana: " + vika_sana);
    Console.WriteLine("Lyhin sana: " + lyhin);
    Console.WriteLine("Pisin sana: " + pisin);
}

