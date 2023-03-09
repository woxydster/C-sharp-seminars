// Задача 32. Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные
// и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]

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

void InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=arr[i]*-1;
    }    
}


int[] array = CreatArrayRndInt(12, -9, 9);
PrintArray(array);
Console.Write($" -> ");
InversArray(array);
PrintArray(array);