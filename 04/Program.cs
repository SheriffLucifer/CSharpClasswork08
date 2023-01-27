﻿// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен 
// наименьший элемент массива.

Console.Clear();
int[,] array = GetArray(6, 8, 0, 10);
PrintArray(array);
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

int[,] DeleteRowColumn(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int minNumber = array[0, 0];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {

        }

    }
}