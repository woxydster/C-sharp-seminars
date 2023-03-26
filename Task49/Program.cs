﻿// Задача 49. Задайте двумерный массив
// Найдите элементы у которых 2 индекса четные
// и замените эти элементы на их квадраты
// 
// 0  4  7  2                   1  4  49  2
// 5  9  2  3      --->         5  9   2  3
// 8  4  2  4                  64  4   4  4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

void FindAndSquarePositiveElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2d);
FindAndSquarePositiveElement(array2d);
Console.WriteLine();
PrintMatrix(array2d);