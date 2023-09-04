// 37. Найдите произведение пар  чисел в одномерном массиве. Парой считаем 
// первый и последний элемент и т.д.
// запишите результатт в новом массиве [1, 2, 3, 4] => 4, 6

/*
var arr = GenerateArray(12);

PrintArray(arr);
Console.WriteLine();
*/
int [] NewArray = GetSumOfPairs(new int [] {1, 2, 3, 4});
PrintArray(NewArray);


/*int[] GenerateArray(int length)// метод создает ранд массив целого размера
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result;
}
*/
void PrintArray(int[] array)// метод выводящий элементы массива
{
    foreach (int i in array) Console.Write($"{i} ");
}

int [] GetSumOfPairs(int[] array)
{
    int newSize = array.Length / 2;
    if (array.Length % 2 == 1)
    {
        newSize++;
    }

    int[] result = new int[newSize];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1)
    {
        result[newSize - 1] = array[array.Length / 2];
    }
    return result;
}
