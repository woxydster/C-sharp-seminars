// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreatArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min,1,MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double DifferenceBetweenMinAndMax(double minElement, double maxElement)
{
    double difference = maxElement - minElement;
    return difference;
}

double FindMinValue(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    return minElement;
}

double FindMaxValue(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    return maxElement;
}
double[] array = CreatArrayRndInt(100, 1, 90);
double resultMin = Math.Round(FindMinValue(array),1,MidpointRounding.ToZero);
double resultMax = Math.Round(FindMaxValue(array),1,MidpointRounding.ToZero);
PrintArray(array);
Console.WriteLine($" - > Минимальное значение элемента массива = {resultMin}, Максимальное значение элемента = {resultMax}. ");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceBetweenMinAndMax(resultMin, resultMax)}.");