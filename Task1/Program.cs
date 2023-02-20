/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  
*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
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

int GetEvenNumber(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }        
    }

    return result;
}

int[] arr = InitArray();
PrintArray(arr);

int evenNumber = GetEvenNumber(arr);
Console.WriteLine($"Колличество четных числе в масcиве = {evenNumber}");