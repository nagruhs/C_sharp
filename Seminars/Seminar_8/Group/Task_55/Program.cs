// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// метод создает двумерный массив int со случайными значениями:
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] DoubleRandom2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            DoubleRandom2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return DoubleRandom2dArray;
}

// метод вывода массива на печать
void PrintDouble2dArray(int[,] inArray)
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

int[,] ChangeRowsToColumns(int[,] userArray)
{

    if (userArray.GetLength(0) == userArray.GetLength(1))
    {
        int[,] resultArray = new int[userArray.GetLength(0), userArray.GetLength(1)];
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            for (int j = 0; j < userArray.GetLength(1); j++)
            {
                resultArray[i, j] = userArray[j, i];
            }
        }
        return resultArray;
    }
    else
    {
        Console.WriteLine("Массив перевернуть невозможно");
        return userArray;
    }
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
PrintDouble2dArray(array);
Console.WriteLine();
int[,] result = ChangeRowsToColumns(array);
PrintDouble2dArray(result);


