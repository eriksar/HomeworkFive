/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-99, 100);
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

int GetSumNumber(int[] array)
{
    int sum = 0;
    
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] arr = InitArray();
PrintArray(arr);

int sum = GetSumNumber(arr);
Console.WriteLine($"сумма элементов стоящих на нечётных позициях равна {sum}");
