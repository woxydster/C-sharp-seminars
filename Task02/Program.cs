// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа");
int number_one = Convert.ToInt32(Console.ReadLine());
int number_two = Convert.ToInt32(Console.ReadLine());

if (number_one > number_two)
{
    Console.Write($"Максимальное число - {number_one}");
}
else
{
    Console.Write($"Максимальное число - {number_two}");
}