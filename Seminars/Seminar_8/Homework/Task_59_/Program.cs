// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

// метод поиска минимального значения и его индексов
int[] SearchMinIndexes(int[,] array)
{
    int[] position = new int[2]; // результат запишу в одномерный массив с двумя значениями
    int temp = array[0, 0]; // за минимум беру верхнее левое значение
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0] = i;
                position[1] = j;
                temp = array[i, j];
            }
        }
    }
    Console.WriteLine($"Наименьший элемент: {temp}");
    // Console.WriteLine($"с индексами {String.Join(" и ", position)} (помним, что индексы считаются с нуля)");
    return position;
}

// метод удаления строки и столбца из массива
int[,] RemoveRowColumn(int[,] array, int[] position)
{
    if (array.GetLength(0) == 1 || array.GetLength(1) == 1)
        return new int[0, 0]; //если изначальный массив был 1х1, то возвращаю "пустоту"

    int[,] newArrray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newArrray.GetLength(0); i++)
    {
        for (int j = 0; j < newArrray.GetLength(1); j++)
        {
            if (i < position[0] && j < position[1])
                newArrray[i, j] = array[i, j];
            else if (i < position[0] && j >= position[1])
                newArrray[i, j] = array[i, j + 1];
            else if (i >= position[0] && j < position[1])
                newArrray[i, j] = array[i + 1, j];
            else
                newArrray[i, j] = array[i + 1, j + 1];
        }
    }
    return newArrray;
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

int[] tempArray = SearchMinIndexes(array);
Console.WriteLine();
int[,] result = RemoveRowColumn(array, tempArray);
Console.WriteLine("на выходе получим следующий массив:");
Print2dArray(result);