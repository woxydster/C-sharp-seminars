// Задача 40: Напишите программу, которая принимает на вход 3 числа и. 
// проверяет, может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите стороны треугольника  ");
int sideA = Prompt("Введите сторону А  ");
int sideB = Prompt("Введите сторону B  ");
int sideC = Prompt("Введите сторону C  ");


int Prompt(string message)                  // 
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

bool DoesTriangleExist(int sideOne, int sideTwo, int sideThree)
{
    return sideOne + sideTwo > sideThree
        && sideTwo + sideThree > sideOne
        && sideThree + sideOne > sideTwo;
}
bool result = DoesTriangleExist(sideA, sideB, sideC);
if(result) Console.WriteLine("Треугольник с такими сторонами существует");
else Console.WriteLine("Треугольник с такими сторонами не существует");

