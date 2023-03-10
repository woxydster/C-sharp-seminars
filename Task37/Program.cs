﻿// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// парой считаем первый и последний элемент, второй и предпоследний и т. д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

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

int[] MultiplicationPairOfNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;

    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = (arr[i] * arr[arr.Length - 1 - i]);
    }
    if (newArray.Length % 2 != 0)
        newArray[newArray.Length-1] = arr[size-1];
        return newArray;

}
int[] array = CreatArrayRndInt(5, 1, 9);
int[] productArray = MultiplicationPairOfNumbers(array);
PrintArray(array);
Console.Write(" - > ");
PrintArray(productArray);
//2:24:44 seminar 5