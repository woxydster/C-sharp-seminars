// 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int number = Prompt("Введите натуральное число ");

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}


int sum = Sum(number);

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)

    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");