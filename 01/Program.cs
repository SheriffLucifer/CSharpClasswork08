Console.Clear();
int[,] array = GetArray(6, 8, 0, 10);
PrintArray(array);
ReverseRows(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReverseRows(int[,] inArray)
{
    Console.WriteLine("Меняем первую и последнюю строку массива");
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int tmp = inArray[0, i];
        inArray[0, i] = inArray[inArray.GetLength(0) - 1, i];
        inArray[inArray.GetLength(0) - 1, i] = tmp;
    }
}