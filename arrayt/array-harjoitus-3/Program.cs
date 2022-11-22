//
// Vaihtoehto 1
//

// Console.Write("Sana: ");
// string input1 = Console.ReadLine();

// Console.Write("Sana: ");
// string input2 = Console.ReadLine();

// Console.Write("Sana: ");
// string input3 = Console.ReadLine();

// string[] sanat = { input1, input2, input3 };

// Console.WriteLine(sanat[2]);
// Console.WriteLine(sanat[1]);
// Console.WriteLine(sanat[0]);

//
// Vaihtoehto 2
//

string[] sanat = new string[3];
int index = 0;

Console.Write("Sana: ");
string input1 = Console.ReadLine();
sanat[index] = input1;
index = index + 1;

Console.Write("Sana: ");
input1 = Console.ReadLine();
sanat[index] = input1;
index = index + 1;

Console.Write("Sana: ");
input1 = Console.ReadLine();
sanat[index] = input1;

Console.WriteLine(sanat[2]);
Console.WriteLine(sanat[1]);
Console.WriteLine(sanat[0]);