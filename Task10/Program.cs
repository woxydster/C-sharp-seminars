// 10. Напишите программу, которая прнимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа
// 456 --> 5
// 782 --> 8
// 918 --> 1

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 999)
{
    Console.WriteLine($"Вторая цифра числа равна {SecondDigit(number)}");
}
else Console.WriteLine("Введите трёхзначное число!");

int SecondDigit(int arg)
{
    int firstDigit = arg / 100;
    int lastDigit = arg % 10;
    return (arg - firstDigit * 100 - lastDigit)/10;
    
    // Реализация в строке
    // return (arg - arg / 100 * 100 - arg % 10) / 10;  
    // Бутет ли верна реализация только этой одной строкой в теле метода
    // без использования переменных firstDigit и lastDigit?
}

