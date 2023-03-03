// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int arrayElements = Prompt("Введите количество элементов массива ");
int[] array = FillArray(arrayElements);
PrintArray(array);

int Prompt(string message)                  // Метод ввода числа int
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

int[] FillArray(int arg)
{
    int[] arr = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        
    }
    Console.Write("]");
}