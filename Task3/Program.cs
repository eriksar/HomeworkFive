/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 100);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetDiffMaxMinNumbers(int[] array)
{  
    int maxNumber = array[0];
    int minNumber = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }

    int diffNumbers = maxNumber - minNumber;

    return diffNumbers;
}


int[] arr = InitArray();
PrintArray(arr);

int diffNumbers = GetDiffMaxMinNumbers(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {diffNumbers}");