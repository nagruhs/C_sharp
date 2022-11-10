// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

// метод преобразования двумерного массива в одномерный
int[] SingleArray(int[,] BiArray)
{
    int[] result = new int[BiArray.GetLength(0) * BiArray.GetLength(1)]; // кол-во эл-тов в массиве=кол-ву всех эл-отв
    int k = 0;
    for (int i = 0; i < BiArray.GetLength(0); i++)
    {
        for (int j = 0; j < BiArray.GetLength(1); j++)
        {
            result[k++] = BiArray[i, j];
        }
    }
    return result;
}

// метод сортировки "пузырьком"
void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}

// метод подсчета количества значений в массиве
void CountFindNumberInArray(int[] inarray)
{
    int count = 1;
    int numberZero = inarray[0];
    for (int i = 1; i < inarray.Length; i++)
    {
        if (inarray[i] == numberZero)
            count++;
        else
        {
            Console.WriteLine($"число {numberZero} встречается {count} раз");
            numberZero = inarray[i];
            count = 1;
        }
    }
    Console.WriteLine($"число {numberZero} встречается {count} раз"); // добавил эту строку еще раз т.к. изначально в программе, разобранной на семинаре, не выводилось количество последних значений массива.
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

int[] array1D = SingleArray(array);
SortArray(array1D);
Console.WriteLine($"[{String.Join(", ", array1D)}]");
CountFindNumberInArray(array1D);