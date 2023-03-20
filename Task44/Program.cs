// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// При N = 5 -> 00123

int userNumber = Prompt("Введите натуральное число  ");

int Prompt(string message)                  // 
{
    Console.Write(message);
    int readNumber = Convert.ToInt32(Console.ReadLine());
    return readNumber;
}

void PrintArray(int[] arr)
{
    Console.Write($"N = {userNumber} -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

int[] FibonacciArray(int num)
{    
    int[] array = new int [num];
    array[0] = 0;
    array[1] = 1;
        for (int i = 2; i < num; i++)
        {
            array[i]= array[i-2]+array[i-1];
        }
    return array;
}

int[] fibonacci = FibonacciArray(userNumber);
PrintArray(fibonacci);
