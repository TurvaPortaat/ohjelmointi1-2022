for (int luku = 0; luku <= 100; luku++)
{
    if (luku % 16 == 0)
    {
        Console.WriteLine(luku);
    }
}

Console.WriteLine("---");

for (int i = 0; i <= 100; i += 16)
{
    Console.WriteLine(i);
}