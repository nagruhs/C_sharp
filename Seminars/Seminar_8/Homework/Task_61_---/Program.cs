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



// // мои первые попытки.. равносторонний получился(
// void PascalTriangle(int n)
// {

//     int temp = 0;
//     for (int line = 1; line <= n; line++)
//     {
//         SpaceNice(n - temp / 2);
//         int num = 1;

//         for (int i = 1; i <= line; i++)
//         {

//             Console.Write($"{num}\t");
//             num = num * (line - i) / i;


//         }

//         Console.WriteLine();
//         temp++;
//     }
// }

// void SpaceNice(int n)
// {
//     int space = 0;
//     while (space < n)
//     {
//         Console.Write(" \t");
//         space++;
//     }
// }

// // Console.Clear();
// Console.Write("Введите количество строк: ");
// int n = int.Parse(Console.ReadLine()!);
// PascalTriangle(n);





