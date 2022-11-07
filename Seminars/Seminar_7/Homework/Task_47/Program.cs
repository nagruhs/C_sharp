// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// метод создает двумерный массив double со случайными значениями:
double[,] GetDouble2dArray(int m, int n, double maxValue, double minValue)
{
    double[,] DoubleRandom2dArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            DoubleRandom2dArray[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return DoubleRandom2dArray;
}

// метод вывода массива на печать
void PrintDouble2dArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f2}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
double minValue = double.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
double maxValue = double.Parse(Console.ReadLine()!);

double[,] array = GetDouble2dArray(rows, columns, maxValue, minValue);
PrintDouble2dArray(array);