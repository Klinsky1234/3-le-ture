
/*2. Найти позицию максимального элемента и отсортировать массив с большего к меньшему
6 8 3 2 1 4 5 7
8 7 6 5 4 3 2 1 
*/
int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void sel(int[] array)
{
    for (int a = 0; a < array.Length - 1; a++)
    {
        int maxPosition = a;
        for (int b = a + 1; b < array.Length; b++)
        {
            if (array[b] > array[maxPosition]) maxPosition = b;
        }
        int temp = array[a];
        array[a] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(arr);
sel(arr);
PrintArray(arr);