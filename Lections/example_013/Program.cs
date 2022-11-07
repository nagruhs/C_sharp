// string[,] table = new string[2, 5];
// table[1, 2] = "слово";


// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table[i, j]}-");
//     }
// }


int[,] matrix = new int[10, 40];

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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 2);
        }
    }
}

void PrintImage(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (matr[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if (matrix[row, col] == 0)
    {
        matrix[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}




PrintArray(matrix);
FillArray(matrix);
FillImage(5, 5);
PrintImage(matrix);




