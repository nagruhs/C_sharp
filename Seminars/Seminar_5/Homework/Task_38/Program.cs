// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Метод создания массива c рандомными числами (minlenght - минимальная длина массива, maxlenght - максимальная длина массива, mindigit - минимальное число в значении, maxdigit - максимальное число в значении)

int[] RandomArr(int minlenght, int maxlenght, int mindigit, int maxdigit)
{
    int[] array = new int[new Random().Next(minlenght, maxlenght + 1)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(mindigit, maxdigit + 1);
    }
    return array;
}


// вывод массива на экран
void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
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
int[] ArrayResult = RandomArr(5, 10, 0, 99);
int result = MaxMinResult(ArrayResult);

Console.Write("В массиве: ");
PrintArray(ArrayResult);
Console.WriteLine($" разница между максимальным и минимальным элементов массива= {result}");