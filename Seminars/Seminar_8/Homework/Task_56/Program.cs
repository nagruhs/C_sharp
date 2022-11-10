// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//  метод создания двумерного массива
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Random2dArray;
}

// метод вывода массива на печать
void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

// Функция вывода номера строки с наименьшей суммой элементов 
void NumberOfRowsMinSum(int[,] array)
{
    int tempSum;
    int minSum = 0;
    int result = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        minSum += array[0, column];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        tempSum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            tempSum += array[row, column];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            result = row;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
Print2dArray(array);
Console.WriteLine();
NumberOfRowsMinSum(array);









// // первый вариант (через одномерный массив)

// // метод поиска сумм значений в строках двумерного массива:
// int[] SumFromRows(int[,] array)
// {
//     int sum = 0;
//     int[] result = new int[array.GetLength(0)];

//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         sum = 0;
//         for (int column = 0; column < array.GetLength(1); column++)
//         {
//             sum += array[row, column];
//         }
//         result[row] = sum;
//     }
//     return result;
// }

// // метод поиска наименьшего значения в одномерном массиве и вывода его индекса:
// int IndexOfMinValue(int[] array)
// {
//     int min = array[0];
//     int result = 0;
//     for (int index = 1; index < array.Length; index++)
//     {
//         if (array[index] < min) min = array[index];
//         result = index;

//     }
//     return result;
// }



// int[] ArrayResult = SumFromRows(array);
// Console.WriteLine($"[{String.Join(", ", ArrayResult)}]"); // вывод сумм строк для проверки результата
// Console.WriteLine($"строка с наименьшей суммой элементов: {IndexOfMinValue(ArrayResult) + 1}");