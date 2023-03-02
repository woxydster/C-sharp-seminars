// 17. Напишите программу, которая по заданному номеру четверти   
// показывает диапазон возможных координат точек в этой четверти
string Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

string Coordinates(string arg)
{
    if (arg == "1") return $"X > 0 и Y > 0";
    if (arg == "2") return $"X < 0 и Y > 0";
    if (arg == "3") return $"X < 0 и Y < 0";
    if (arg == "4") return $"X > 0 и Y < 0";

    return "0";
}

string quarter = Prompt("Введите номер четверти ");
string coordinate = Coordinates(quarter);
string result = coordinate == "0" 
                ? $"Ошибка ввода"
                : $"Диапазон возможных координат точек в этой облатсти лежит в {coordinate}";

Console.WriteLine(result);




