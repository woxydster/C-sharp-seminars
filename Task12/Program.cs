// 12. Напишите программу, которая будет принимать на вход два числа
// и выводить является ли первое число кратное второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления
// 34,5  --> не кратно, отаток 4
// 16,4 --> кратно


int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = firstNumber % secondNumber;

// if (result == 0) Console.WriteLine("Первое число кратно второму");
// else Console.WriteLine($"Первое число не кратно второму. Остаток {result}");

int multyplay = Multyplay(firstNumber, secondNumber);

if (multyplay == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine($"Первое число не кратно второму. Остаток {multyplay}");

int Multyplay(int fNum, int sNum)
{
    return fNum % sNum;
}
