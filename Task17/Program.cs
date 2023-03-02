// 17. Напишите программу, которая принимает на вход координаты  
// точки (X и Y), причем X и Y не равны 0 и выдаёт номер четверти
// плоскости в которой находится эта точка.

Console.WriteLine("Введите координаты точки X и Y ");
Console.Write("X: ");
int coordinateAbs = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int coordinateOrd = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(coordinateAbs,coordinateOrd);

string result = quarter>0 
                ? $"Указанные координаты соответствуют четверти {quarter}"
                : $"Введены некорректные координаты";

Console.WriteLine(result);

int Quarter(int abs, int ord)
{
    if (abs>0 && ord>0) return 1;
    if (abs<0 && ord>0) return 2;
    if (abs<0 && ord<0) return 3;
    if (abs>0 && ord<0) return 4;

    return 0;    
}