// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Across(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}

Console.Clear();
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Across(b1, k1, b2, k2);
