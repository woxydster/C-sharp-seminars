// 13. Напишите программу, которая выводит третью цифру заданного числа  
// или сообщает, что третьей цифры нет.
// 645 --> 4
// 78 --> третьей цифры нет
// 32679 --> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("Третьей цифры нет.");
else Console.WriteLine($"Третья цифра числа равна {ThirdDigit(number)}");


int ThirdDigit(int arg)
{
    while (arg > 999) arg = arg / 10;
   
    return arg % 10;
}


