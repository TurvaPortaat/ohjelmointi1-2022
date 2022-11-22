Console.Write("Luku: ");
string luku1 = Console.ReadLine();

Console.Write("Luku: ");
string luku2 = Console.ReadLine();

Console.Write("Luku: ");
string luku3 = Console.ReadLine();

// muutetaan merkkijonot kokonaisluvuiksi taulukon luonnissa
int[] luvut = { int.Parse(luku1), int.Parse(luku2), int.Parse(luku3) };

// Console.Write("Anna 3 lukua pilkulla eroteltuna: ");
// string input = Console.ReadLine();
// string[] luvut_str = input.Split(",");
// int[] luvut = { int.Parse(luvut_str[0]), int.Parse(luvut_str[1]), int.Parse(luvut_str[2]) };

Console.Write("Suoritetaanko luvuille kertolasku (*), summaus (+) vai vähennys (-)?: ");
string operaatio = Console.ReadLine();

int tulos = -999;
if (operaatio == "*")
{
    tulos = luvut[0] * luvut[1] * luvut[2];
}
else if (operaatio == "-")
{
    tulos = luvut[0] - luvut[1] - luvut[2];
}
else if (operaatio == "+")
{
    tulos = luvut[0] + luvut[1] + luvut[2];
}

string tuloste = luvut[0] + operaatio + luvut[1] + operaatio + luvut[2] + "=" + tulos;
Console.WriteLine(tuloste);