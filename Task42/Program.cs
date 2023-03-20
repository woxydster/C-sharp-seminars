// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное

// 45 -> 101101
//  3 -> 11
//  2 -> 10


// остаток от деления на 2 и реверс числа

int userNumber = Prompt("Введите натуральное число  ");


int Prompt(string message)                  // 
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

string ConvertDecimalToBinary(int num)
{
    string number = String.Empty;
    while (num!=0)
    {
        number = num%2 +number;
        num=num/2;
    }
    return number;
}

Console.Write($"{userNumber} - > {ConvertDecimalToBinary(userNumber)}");