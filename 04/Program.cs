// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен 
// наименьший элемент массива.

Console.Clear();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
int[,] minEl = new int[1, 2];
minEl = FindMinElement(array, minEl);

Console.WriteLine("Удаление строки и столбца при пересечении наименьшим значении в массиве:");
int[,] newArray = DeleteRowColumn(array, minEl);
PrintArray(newArray);

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

int[,] FindMinElement(int[,] array, int[,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = array[i, j];
            }
        }
    }
    return position;
}

int[,] DeleteRowColumn(int[,] array, int[,] positionMinEl)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (positionMinEl[0, 0] != i && positionMinEl[0, 1] != j)
            {
                newArray[k, l] = array[i, j];
                l++;
            }
        }
        l = 0;
        if (positionMinEl[0, 0] != i)
        {
            k++;
        }
    }
    return newArray;
}