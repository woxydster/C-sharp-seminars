﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double pointX;
double pointY;
Console.Write("Введите значения переменных b1, k1, b2 и k2: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"x= {pointX:0.00}");
    Console.WriteLine($"y= {pointY:0.00}");
}
