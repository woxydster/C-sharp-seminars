// Задача 33. Задайте массив. Напишите программу, которая определяет 
// присутствует ли данное число в массиве.
// 4 - [6,7,9,345,3] -> нет
// 3 - [6,7,9,345,3] -> да

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

bool FindNumber(int[] arr,int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]==num) return true;        
    }
    return false;
}

int[] array = CreatArrayRndInt(12, -9, 9);
// int[] array = {0,1,2,3,4,5,6,7,8,9};
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомое число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"{userNumber} - ");
PrintArray(array);
Console.Write(" -> ");
if (FindNumber(array,userNumber)) Console.Write(" yes ");
else Console.Write(" no ");
