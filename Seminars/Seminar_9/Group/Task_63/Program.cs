// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NumbersRec(int b)
{
    if (b == 1) return "1 ";
    else
    {
        // Console.WriteLine(b);
        return $"{NumbersRec(b - 1) + b} ";
    }
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(NumbersRec(n));





// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }



// Console.Clear();
// Console.Write("Введите начальное число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конечное число: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{NumbersRec(1, n)}");