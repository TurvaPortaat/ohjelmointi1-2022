Console.Write("Montako sanaa syötät: ");
string input = Console.ReadLine();

int count = int.Parse(input);

int total_len = 0;

int word_count = 0;
while (word_count < count)
{
    Console.Write("sana: ");
    input = Console.ReadLine();
    if (input.Length > 0)
    {
        total_len += input.Length;
        word_count++;
    }
}

Console.WriteLine("yhteenlaskettu pituus " + total_len);