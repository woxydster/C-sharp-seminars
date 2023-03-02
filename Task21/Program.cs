// 20. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8);  B (2,1,-7)  --> 15.84
// A (7,-5,0); B (1,-,1,9) --> 11.53

Console.WriteLine("Введите координаты точки X и точки Y");

int coordinateX1 = Prompt("У точки X -> x: ");
int coordinateY1 = Prompt("У точки X -> y: ");
int coordinateZ1 = Prompt("У точки X -> z: ");
int coordinateX2 = Prompt("У точки Y -> x: ");
int coordinateY2 = Prompt("У точки Y -> y: ");
int coordinateZ2 = Prompt("У точки Y -> z: ");

int Prompt(string message)                  // 
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}


double segmentLength = SegmentLenght(coordinateX1, coordinateY1, coordinateZ1, coordinateX1,coordinateY2,coordinateZ2);

double SegmentLenght(double abs1, double ord1, double app1, double abs2,double ord2, double app2)
{
    return Math.Sqrt(Math.Pow(abs2 - abs1, 2) + Math.Pow(ord2 - ord1, 2)+ Math.Pow(app2 - app1, 2));
}

Console.WriteLine($"Расстояние между точками в 3D пространстве: {Math.Round(segmentLength, 3, MidpointRounding.ToZero)}");




