// // i++ == i = i + 1
// int[] nums = { 1, 2, 3 };
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
//     if (i == 1)
//     {
//         break;
//     }
// }

// int count = 0;
// while (true)
// {
//     Console.WriteLine(count);
//     count++;
//     if (count == 4)
//     {
//         break;
//     }
// }

int[] nums = { 1, 2, 3, 12, 2 };

foreach (int numero in nums)
{
    if (numero == 2)
    {
        continue;
    }
    Console.WriteLine(numero);
}