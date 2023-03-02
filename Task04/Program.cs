// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int number_one = Convert.ToInt32(Console.ReadLine());
int number_two = Convert.ToInt32(Console.ReadLine());
int number_three = Convert.ToInt32(Console.ReadLine());

int max = number_one;

if (number_two > max)
{
    max = number_two;
}

if (number_three > max)   
{
    max = number_three;
}

Console.Write($"Максимальное число - {max}");
