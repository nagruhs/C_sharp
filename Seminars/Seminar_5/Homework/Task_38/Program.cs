// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// // метод находит разницу между максимальным и минимальным элементами массива
// int MaxMinResult(int[] array)
// {
//     int min = array[0];
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];

//     }
//     int result = max - min;
//     return result;
// }


// // программа
// Console.Clear();
// int[] ArrayResult = GetArray(5, 0, 99);
// int result = MaxMinResult(ArrayResult);
// Console.WriteLine($"В массиве {String.Join(", ", ArrayResult)} разница между максимальным и минимальным элементов массива = {result}");







////то же но с double

double[] GetArray(int size, double maximum, double minimum)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maximum - minimum) + minimum;
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

// метод находит разницу между максимальным и минимальным элементами массива
double MaxMinResult(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    double result = max - min;
    return result;
}

// программа
Console.Clear();
double[] ArrayResult = GetArray(5, 10, 99);
double result = MaxMinResult(ArrayResult);
Console.WriteLine($"В массиве [{String.Join(", ", ArrayResult)}] разница между максимальным и минимальным элементов массива = {result:f2}");