// Задача 35.Задайте одномерный массив из 123 случайных чиселю
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
// [5,18,123,6,2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

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

int CountTwoSignArray(int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i]>= 10 && arr[i]<= 99) count++;
    }
    return count;
}
int[] array = CreatArrayRndInt(123, 0, 100);
PrintArray(array);
Console.Write($" - > {CountTwoSignArray(array)}");