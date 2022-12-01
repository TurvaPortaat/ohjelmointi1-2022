decimal[] luvut = { 1.1m, 1.2m, 1.3m };

decimal summa = 0.0m;

for (int i = 0; i < luvut.Length; i++)
{
    summa = summa + luvut[i];
}
Console.WriteLine(summa);
Console.WriteLine("----");

summa = 0.0m;

int index = 0;
while (index < luvut.Length)
{
    summa += luvut[index];
    index++;
}
Console.WriteLine(summa);
Console.WriteLine("----");

summa = 0.0m;

foreach (decimal luku in luvut)
{
    summa += luku;
}
Console.WriteLine(summa);