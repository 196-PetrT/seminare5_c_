// Задача 33: Напишите программу, которая определяет присутствует ли заданное  
// число среди элементов массива

var array = GenerateArray(8);

PrintArray(array);

Console.Write(FoundItemArr(array, 8)); // выводит результат, можно прописть в коде вывод, тогда здесь без console.Write


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

bool FoundItemArr(int[] array, int Num)// можно задать аргументы и (int Num, int [] arr) разницы нет
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num) return true;
    }  
    return false; // не промахнись
}