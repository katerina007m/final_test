void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[5] { "123", "yes", "no", "world", "res" };
string[] array2 = new string[array1.Length];