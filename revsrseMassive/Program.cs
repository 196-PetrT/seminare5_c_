// Задача 32: Напишите программу, которая заменет положительные  
//элементы на отрицательные и наоборот

var array = GenerateArray(8);

PrintArray(array);

ReverseNum(array);
Console.WriteLine();
PrintArray(array);

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 99);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int[] ReverseNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    } 
    return array;
}