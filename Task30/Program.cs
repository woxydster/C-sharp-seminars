// Задача 30: Напишите программу, которая задаёт массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]



int arrayElements = Prompt("Введите количество элементов массива ");
int[] array = FillArray(arrayElements,0,1);
PrintArray(array);

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

int[] FillArray(int arg,int min,int max)
{
    Random rand = new Random();
    int[] arr = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}