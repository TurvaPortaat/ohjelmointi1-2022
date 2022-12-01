int[] luvut = new int[10];

for (int i = 0; i < 10; i++)
{
    luvut[i] = i * i;
}

// for (int k = 0; k < luvut.Length; k++)
// {
//     Console.WriteLine(luvut[k]);
// }

for (int k = 0; k < luvut.Length; k += 2)
{
    Console.WriteLine(luvut[k] + ", " + luvut[k + 1]);
}