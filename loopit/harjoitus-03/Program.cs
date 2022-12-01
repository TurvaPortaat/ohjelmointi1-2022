int maara = 3;
string[] sanat = new string[maara];
int seuraava_index = 0;

for (int i = 0; i < maara; i++)
{
    string syote = Console.ReadLine();
    sanat[seuraava_index] = syote;
    seuraava_index++;
}

for (int k = maara - 1; k >= 0; k--)
{
    Console.WriteLine(sanat[k]);
}