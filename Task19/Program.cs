// 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет является ли оно палиндромом.
// 14212 --> нет
// 23432 --> да
// 12821 --> да
// цикл while и 2 строки. Надо перевернуть число
// ---------------------------------Не решена-----------------------------

int number = Prompt("Введите пятизначное число ");

int Prompt(string message)                  // 
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

string CheckPolyndrome(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number - firstDigit * 10000) / 1000;
    int fourthDigit = (number % 100) / 10;
    int lastDigit = number % 10;
    
    return firstDigit == lastDigit && secondDigit == fourthDigit 
                        ? "Это число является полиндром"
                        : "Это число не является полиндром";
}

Console.WriteLine(CheckPolyndrome(number));

