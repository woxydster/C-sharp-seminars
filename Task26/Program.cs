// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int number = Prompt("Введите натуральное число ");

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

int numberOfDigits = NumberOfDigits(number);

int NumberOfDigits(int num)
{
    int numberOfDigits = 0;
    while (num != 0)
    {
        num = num / 10;
        numberOfDigits = numberOfDigits + 1;
    }
    return numberOfDigits;
}

Console.WriteLine($"Количество цифр в числе равно {numberOfDigits}");