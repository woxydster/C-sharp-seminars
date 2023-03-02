// 22. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов числел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// ---------------------------------Не решена-----------------------------


int number = Prompt("Введите натуральное число ");


int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

// ------------Решение через цикл while-----------
//
// TableOfSquares(number);
//
// void TableOfSquares(int num)
// {
//     int index = 1;
//     while (index <= num)
//     {
//         Console.WriteLine($"{index,5} - {index * index,5}");
//         index++;
//     }
// }



// -----------Решение через цикл for---------------
//
if (number > 0) TableOfCubes(number);
else Console.WriteLine("Ошибка ввода. Введите натуральное число.");

void TableOfCubes(int num)
{
    Console.WriteLine("| Число  |  Куб числа  |");
    for (int i = 1; i < num+1; i++)
    {
        Console.WriteLine($"{i,5}     {Math.Pow(i,3),7}");
    }
}


