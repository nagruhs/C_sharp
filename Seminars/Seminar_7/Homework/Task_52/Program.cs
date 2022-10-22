// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// метод создает двумерный массив со случайным количеством строк, столбцов и значений:
int[,] Get2dRandomArray()
{
    int m = new Random().Next(3, 6);
    int n = new Random().Next(3, 6);
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 11);
        }
    }
    return inArray;
}

// метод вывода двумерного массива:
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

// метод вывода среднего арифмитического в столбцах массива:
void AverageOfColumns(int[,] array)
{
    double sum = 0;
    double[] result = new double[array.GetLength(1)]; // создаю массив по размеру равный количеству столбцов.

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round(sum / array.GetLength(0), 2); //делю сумму чисел в столбце на количество строк (т.е. на количество чисел в столбце) и записываю результат в мой созданный массив.
    }
    Console.WriteLine($"[{String.Join("; ", result)}]");
}

Console.Clear();
int[,] myArray = Get2dRandomArray();
Print2dArray(myArray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
AverageOfColumns(myArray);
