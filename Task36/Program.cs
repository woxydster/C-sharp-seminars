// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumOfValuesOddIndexes (int[] arr)
{
    int sumValues = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sumValues=sumValues+arr[i];
    }
    return sumValues;
}
int[] array = CreatArrayRndInt(50, 1, 90);
int result = SumOfValuesOddIndexes(array);
PrintArray(array);
Console.Write($" - > {result}");