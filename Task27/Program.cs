// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int userNumber = Prompt("Введите натуральное число ");

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

int sumOfDigits = SumOfDigits(userNumber);

int SumOfDigits(int num)
{
    int sumOfDigits = 0;
    while (num != 0)
    {
        int lastDigit = num % 10;
        sumOfDigits = sumOfDigits + lastDigit;
        num = num / 10;
    }
    return sumOfDigits;
}

Console.WriteLine($"Сумма цифр в числе равна {sumOfDigits}");