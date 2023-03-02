// 28. Напишите программу, которая принимает на вход число (N)
// и выдаёт произведение чисел от 1 до Т
// 4 -> 24
// 5 -> 120

int userNumber = Prompt("Введите натуральное число ");

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}


int factorial = Factorial(userNumber);

int Factorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact =fact * i;
    }
    return fact;
}

Console.WriteLine($"Произведение чисел от 1 до {userNumber} равна {factorial}");