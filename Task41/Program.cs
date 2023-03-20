// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




int Prompt(string message)     

{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

int[] InputArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"{i + 1}-е число = ");
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
    
}

int CountPositiveNumbers(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count ++;
    }
    return count;
}

int size = Prompt("Введите количество чисел ");
int[] array;
array = InputArray(size);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 равно {CountPositiveNumbers(array)}");