// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n. Выведите полученный массив на экран.
//  m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;

}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите количество строк массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);