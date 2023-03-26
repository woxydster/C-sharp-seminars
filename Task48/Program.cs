﻿// Задача 48. Задайте двумерный массив размером m*n,
// каждый элемент массива находится по формуле Amn = m+n.
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4 
// 2 3 4 5 

int[,] CreatMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = CreatMatrixRndInt(5, 5);
PrintMatrix(array2d);