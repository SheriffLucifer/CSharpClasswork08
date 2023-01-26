// Составить частотный словарь
// элементов двумерного массива. 
// Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных

Console.Clear();
int[,] array = GetArray(5, 3, 0, 10);
PrintArray(array);
CheckArray(array, 0, 10);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

void CheckArray(int[,] inArray, int minValue, int maxValue)
{
    int[] countNumber = new int[maxValue - minValue];
    for (int n = 0; n < countNumber.Length; n++)
    {
        int amount = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i, j] == n) amount += 1;
            }
        }
        countNumber[n] = amount;
        if (amount != 0)
        {
            if (amount % 10 == 2 || amount % 10 == 3 || amount % 10 == 4)
                Console.WriteLine($"{n} встречается {amount} раза");
            else
                Console.WriteLine($"{n} встречается {amount} раз");
        }
    }
}