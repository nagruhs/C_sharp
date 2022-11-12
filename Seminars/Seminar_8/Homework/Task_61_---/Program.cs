// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// решение из гугла (телеги) (подкорректированное)
int Factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PascalTriangle(int n)
{
    int i, c, core;
    for (i = 0; i < n; i++)
    {
        for (i = 0; i < n; i++)
        {
            for (c = 0; c <= (n - i); c++)
            {
                Console.Write("  ");
            }
            for (c = 0; c <= i; c++)
            {
                core = Factorial(i) / (Factorial(c) * Factorial(i - c));//формула вычисления элементов треугольника
                if (core > 0 && core < 10) Console.Write("   ");
                if (core >= 10 && core < 100) Console.Write("  ");
                if (core >= 100 && core < 1000) Console.Write(" ");
                Console.Write(core);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}


Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
int n = int.Parse(Console.ReadLine()!);
PascalTriangle(n);





// // решение из лекций
// int[,] FillTriangle(int row)
// {
//     int[,] triangle = new int[row, row];
//     for (int i = 0; i < row; i++)
//     {
//         triangle[i, 0] = 1;
//         triangle[i, i] = 1;
//     }

//     for (int i = 2; i < row; i++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
//         }
//     }
//     return triangle;
// }

// void Magic(int[,] triangle)
// {
//     const int cellWidth = 3;
//     int col = cellWidth * triangle.GetLength(0);
//     {
//         for (int i = 0; i < triangle.GetLength(0); i++)
//         {
//             for (int j = 0; j <= i; j++)
//             {
//                 Console.SetCursorPosition(col, i + 1);
//                 if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
//                 // if (triangle[i, j] % 2 != 0) Console.Write("*"); // бешеный треугольник
//                 col += cellWidth * 2;
//             }

//             col = cellWidth * triangle.GetLength(0) - cellWidth * (i + 1);
//             Console.WriteLine();
//         }

//     }

// }

// Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
// int n = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Magic(FillTriangle(n));




// // // мои первые попытки.. равносторонний получился(
// // void PascalTriangle(int n)
// // {

// //     int temp = 0;
// //     for (int line = 1; line <= n; line++)
// //     {
// //         SpaceNice(n - temp / 2);
// //         int num = 1;

// //         for (int i = 1; i <= line; i++)
// //         {

// //             Console.Write($"{num}\t");
// //             num = num * (line - i) / i;


// //         }

// //         Console.WriteLine();
// //         temp++;
// //     }
// // }

// // void SpaceNice(int n)
// // {
// //     int space = 0;
// //     while (space < n)
// //     {
// //         Console.Write(" \t");
// //         space++;
// //     }
// // }

// // // Console.Clear();
// // Console.Write("Введите количество строк: ");
// // int n = int.Parse(Console.ReadLine()!);
// // PascalTriangle(n);