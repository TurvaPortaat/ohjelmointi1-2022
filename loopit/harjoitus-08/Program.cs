string[] sanat = { "samk", "moi", "ja", "morormor" };

foreach (string sana in sanat)
{
    if (sana.Length < 3)
    {
        continue;
    }
    Console.WriteLine(sana);
}