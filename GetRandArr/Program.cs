// 31. Задайте массив из 12 элементов, заполненным случайными числами из промежутка [-9;9].
// найдите сумму положительных и отрицательных элементов массива


var array = GenerateArray(12); 

PrintArray(array);
Console.Write(SumPosit(array));
Console.Write(SumNegat(array));


int[] GenerateArray(int length)// метод создает ранд массив целого размера
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 10);
    }
    return result;
}

void PrintArray(int[] array)// метод выводящий элементы массива
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int SumPosit(int[] array) // метод считает сумму положительных значений 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sum += array[i];
        
    } 
    Console.WriteLine();
    // Console.Write(sum);  - можно прописать и здесь но из строки запуска убрать вывод метода (только запуск)
    return sum;
}

int SumNegat(int[] array) // метод считает сумму отрицательных значений 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 0) sum += array[i];
        
    } 
    Console.WriteLine();
    
    return sum;
}