// 20. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// ------Новые методы:--------
// Math.Sqrt(5);                    Извлечение квадратного корня
// Math.Pow(2,10)                   Возведение 2 в 10 степень

// -------Oкругление------ а также через форматирование вывода (самостоятельно)
//double d = 5.09998774;
// double dRound = Math.Round(d, 2, MidpointRiunding.ToZero);
// Console.WriteLine(dRound);

Console.WriteLine("Введите координаты точки X и точки Y ");
Console.Write("У точки X -> x: ");
int coordinateX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("У точки X -> y: ");
int coordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("У точки Y -> x: ");
int coordinateX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("У точки Y -> y: ");
int coordinateY2 = Convert.ToInt32(Console.ReadLine());

double segmentLength = SegmentLenght(coordinateX1, coordinateY1, coordinateX2, coordinateY2);

double SegmentLenght(double abs1, double ord1, double abs2, double ord2)
{
    return Math.Sqrt(Math.Pow(abs2 - abs1, 2) + Math.Pow(ord2 - ord1, 2));
}

Console.WriteLine($"Расстояние между точками {Math.Round(segmentLength, 2, MidpointRounding.ToZero)}");




