string[] sanat = { "s1", "s2", "s3", "s4", "s5" };

foreach (string sana in sanat)
{
    Console.WriteLine(sana);
}

Console.WriteLine("----");

for (int i = 0; i < sanat.Length; i++)
{
    Console.WriteLine(sanat[i]);
}
Console.WriteLine("----");

int index = 0;
while (index < sanat.Length)
{
    Console.WriteLine(sanat[index]);
    index++;
}