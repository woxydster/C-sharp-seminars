// 11. Напишите программу, которая выводит случайное трёхзначноечисло
// и удаляет вторую цифру этого числа
// 456 --> 46
// 782 --> 72
// 918 --> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка от 100 до 999 => {number}");

int newNumber = NewNumber(number);

int NewNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

Console.WriteLine($"Новое число из первой и последней цифры => {newNumber}");