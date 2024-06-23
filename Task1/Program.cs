int[] array = { 16, 22, 13, 45, 58 };
int value = 45;
static int LinerSearch(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return i;
        }
    }
    return -1;
}
int index = LinerSearch(array, 45);
Console.WriteLine($"Элемент {value} найден на позиции {index}.");

