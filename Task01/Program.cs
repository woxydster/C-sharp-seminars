/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.WriteLine("Введите первре число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number == second_number * second_number)
{
    Console.WriteLine("Второе число является квадратом второго числа.");
}
else
{
     Console.WriteLine("Второе число НЕ является квадратом второго числа.");
}
