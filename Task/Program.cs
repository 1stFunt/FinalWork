string[] array1 = new string[5] { "E", "Final", "N", "D", "Work" };
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int сharacters = 3;
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= сharacters)
            array2[count++] = array1[i];
    }
}
void PrintArray1(string[] array)
{
    for (int index = 0; index < array.Length; index++)
        continue;
    Console.Write("[" + String.Join(", ", array) + "] -> ");
}
void PrintArray2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray1(array1);
PrintArray2(array2);