string[] array1 = new string[4] {"53", "65", "run5", "dotnet"};
string[] array2 = new string[array1.Length];
int count = 0;
void SAW(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PA(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SAW(array1, array2);
PA(array1);
PA(array2);