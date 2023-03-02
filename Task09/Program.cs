// 9. Напишите программу, которая выводит случайное число из отрезка
// [10,99] и показывает наибольшую цифру числа
// 78 --> 8
// 12 --> 2
// 85 --> 8

// void haier(int )

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10 до 99 => {number}");

// int FirstDigit = number / 10;
// int SecondDigit = number % 10;
// if (FirstDigit > SecondDigit) Console.WriteLine($"Наибольшая цифра числа равна {FirstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа равна {SecondDigit}");


int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");

int MaxDigit(int num) // Метод только для двузначных целых чисел
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;

    // 1 способ
    // if (FirstDigit > SecondDigit) return FirstDigit;
    // return SecondDigit;

    // 2 способ
    // int result = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
    // return result;

    // 3 способ
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}