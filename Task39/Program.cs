// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreatArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp=arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=temp;
    }
}

int[]array = CreatArrayRndInt(15,1,10);
PrintArray(array);
Console.WriteLine();

ReverseArray(array);
PrintArray(array);
Console.WriteLine();
// Встроенный метод разворота массива
Array.Reverse(array);
PrintArray(array);
