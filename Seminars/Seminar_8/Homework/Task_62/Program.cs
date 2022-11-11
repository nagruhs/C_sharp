// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// метод заполнения квадратного массива 4 на 4 (по условию пользователь не вводит никакие данные)
int[,] FillSqrArray()
{
    int size = 4;
    int[,] newArray = new int[size, size];
    int row = 0;
    int column = 0;

    for (int temp = 1; temp <= size * size; temp++)
    {
        newArray[row, column] = temp;
        if (row <= column + 1 && row + column < size - 1) column++;
        else if (row < column && row + column >= size - 1) row++;
        else if (row >= column && row + column > size - 1) column--;
        else row--;
    }
    return newArray;
}

// метод вывода массива на печать
void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            // //вариант с 1 2 3 и т.д.
            // Console.Write($"{inArray[i, j]}\t ");
            // вариант с 01 02 03 и т.д. просто так для красоты
            if (inArray[i, j] < 10) Console.Write($"0{inArray[i, j]}\t ");
            else Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Print2dArray(FillSqrArray());




// // способ из вопроса в телеге
// // метод заполнения квадратного массива 4 на 4 (по условию пользователь не вводит никакие данные)
// int[,] FillSqrArray()
// {
//     int s = 4;
//     int[,] array = new int[s, s];
//     int i = 0; int j = 0;
//     int num = 1;

//     for (int a = 1; a < (s * s); a++)
//     {
//         int k = 0;
//         for (k = 0; k < s - 1; k++) array[i, j++] = num++;
//         for (k = 0; k < s - 1; k++) array[i++, j] = num++;
//         for (k = 0; k < s - 1; k++) array[i, j--] = num++;
//         for (k = 0; k < s - 1; k++) array[i--, j] = num++;
//         ++i; ++j;
//         s = s / 2;
//     }
//     return array;
// }

// // метод вывода массива на печать
// void Print2dArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             // //вариант с 1 2 3 и т.д.
//             // Console.Write($"{inArray[i, j]}\t ");
//             // вариант с 01 02 03 и т.д. просто так для красоты
//             if (inArray[i, j] < 10) Console.Write($"0{inArray[i, j]}\t ");
//             else Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Print2dArray(FillSqrArray());