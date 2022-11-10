// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void PascalTriangle(int n)
{

    int temp = 0;
    for (int line = 1; line <= n; line++)
    {
        SpaceNice(n - temp / 2);
        int num = 1;

        for (int i = 1; i <= line; i++)
        {
            Console.Write($"{num}\t");
            // if (i == line / 2)
            // {
            //     Console.Write($"0\t");
            //     temp--;
            // }
            num = num * (line - i) / i;

        }

        Console.WriteLine();
        temp++;
    }
}

void SpaceNice(int n)
{
    int space = 0;
    while (space < n)
    {
        Console.Write(" \t");
        space++;
    }
}

// Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
PascalTriangle(n);
