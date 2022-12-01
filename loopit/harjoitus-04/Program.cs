int count = 3;
string[] words = new string[count];
int next_index = 0;

while (next_index < count)
{
    string input = Console.ReadLine();
    words[next_index] = input;
    next_index++;
}

int k = count - 1;
while (k >= 0)
{
    Console.WriteLine(words[k]);
    k--;
}