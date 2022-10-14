// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// метод находит разницу между максимальным и минимальным элементами массива
int MaxMinResult(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    int result = max - min;
    return result;
}


// программа
Console.Clear();
int[] ArrayResult = GetArray(5, 0, 99);
int result = MaxMinResult(ArrayResult);
Console.WriteLine($"В массиве {String.Join(", ", ArrayResult)} разница между максимальным и минимальным элементов массива = {result}");