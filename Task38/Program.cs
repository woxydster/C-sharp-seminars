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

int DifferenceBetweenMinAndMax (int minElement,int maxElement)
{
    int difference = maxElement-minElement;
    return difference;
}

int FindMinValue (int[] arr)
{
    int minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement= arr[i];
    }
    return minElement;
}

int FindMaxValue (int[] arr)
{
    int maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement= arr[i];
    }
    return maxElement;
}
int[] array = CreatArrayRndInt(5, 1, 9);
int resultMin = FindMinValue(array);
int resultMax = FindMaxValue(array);
PrintArray(array);
Console.WriteLine($" - > Минимальное значение элемента массива = {resultMin}, Максимальное значение элемента = {resultMax}. ");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceBetweenMinAndMax(resultMin,resultMax)}.");