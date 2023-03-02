// 22. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов числел от 1 до N.

int number = Prompt("Введите натуральное число ");


int Prompt(string message)                  // 
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
if (number > 0) TableOfSquares(number);
else Console.WriteLine("Ошибка ввода. Введите натуральное число.");

void TableOfSquares(int num)
{
    Console.WriteLine("| Число  |  Квадрат числа  |");
    for (int i = 1; i < num; i++)
    {
        Console.WriteLine($"{i,5}     {i * i,10}");
    }
}


