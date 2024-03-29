﻿// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9,9]. И найти сумму отрицательных и положительных элементов массива.

// Например: В массиве [3,8,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// а сумма отрицательных равна -20.

int[] CreatArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}



int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreatArrayRndInt(4, -9, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел  =  {GetSumPositiveElem(array)}");
Console.WriteLine($"Сумма отрицательных чисел  =  {GetSumNegativeElem(array)}");