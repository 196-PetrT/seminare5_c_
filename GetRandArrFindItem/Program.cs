// 35. Задайте одномерный массив из 123 случайных чисел.
// найдите количество элементов массива значения которых лежат [10;99]


var arr = GenerateArray(123);

Console.WriteLine(FindIterval(arr));


int[] GenerateArray(int length)// метод создает ранд массив целого размера
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 1000);
    }
    return result;
}


int FindIterval(int[] array)// метод делает выборку по интервалу и считает количество элементов в ней
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100) //задаем параметры выборки
        {
            count++;
            Console.Write($"{array[i]}  ");// выводим элементы по выборке
        }
    }
    Console.WriteLine();// чтобы не сливался результат перекидываем на след строчку
    return count; // возвращаем значение аргумента
}