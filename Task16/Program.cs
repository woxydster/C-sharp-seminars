// 16. Напишите программу, которая принимает на вход два числа и проверяет
// является ли одно число квадратом другого.
// 5, 25 --> да
// -4, 16 --> да
// 25, 5 --> да
// 8, 9 --> нет

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Square(firstNumber, secondNumber)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool Square(int arg1, int arg2)
{
    return arg1 * arg1 == arg2 || arg2 * arg2 == arg1;
}

