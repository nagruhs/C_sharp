// Задача со звездочкой: Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

// метод заполнения массива
int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
    return matr;
}

// метод вывода массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод развертывания 2-х мерного массива против часовой стрелки
int[] Unravel(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] result = new int[rows * columns];
    int sortedsize = 0;
    int z = 0;
    int j = 0;
    int i = matrix.GetLength(0) - 1 - sortedsize;

    while (z < rows * columns)
    {
        while (j < columns - sortedsize && z < rows * columns) result[z++] = matrix[i, j++]; // иду вправо с начала до конца
        j = j - 1;
        i = rows - sortedsize - 2;
        while (i > sortedsize && z < rows * columns) result[z++] = matrix[i--, j]; //иду вверх (исключая самый верхний и нижний индексы)
        i = sortedsize;
        j = columns - sortedsize - 1;
        while (j > sortedsize - 1 && z < rows * columns) result[z++] = matrix[i, j--]; // иду влево сначала до конца
        j = sortedsize;
        i = sortedsize + 1;
        while (i < rows - sortedsize - 2 && z < rows * columns) result[z++] = matrix[i++, j]; //иду вниз (исключая самый верхний и нижний индексы)
        sortedsize++; // сдвиг индексов "вовнутрь"
    }

    return result;
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = new int[a, b];

PrintArray(FillArray(array));
int[] result = Unravel(array);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", result)}]");