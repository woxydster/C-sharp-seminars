// 15. Напишите программу, которая принимает на вход цифру,  
// обозначающую день недели и проверяет, является ли этот день выходным.
// 6 --> да
// 7 --> да
// 1 --> нет

Console.WriteLine("Введите день недели ");
int day_number = Convert.ToInt32(Console.ReadLine());


if (day_number > 7 || day_number<1) Console.WriteLine("Введите число от 1 до 7");
else 
{
if (Weekend(day_number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");
}

bool Weekend(int arg)
{
    return arg == 1 || arg == 2 || arg ==3 || arg == 4 || arg == 5 ? false: true;
}
