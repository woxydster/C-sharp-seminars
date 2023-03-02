// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int userNumberOne = Prompt("Введите число A ");
int userNumberTwo = Prompt("Введите число B ");

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}
double degreeOfNumber = DegreeOfNumber(userNumberOne,userNumberTwo);

double DegreeOfNumber(double numberOne, double numberTwo)
{
    double degree = Math.Pow(numberOne,numberTwo);
    return degree;
}

Console.WriteLine($"{userNumberOne} в {userNumberTwo} степени = {degreeOfNumber}");