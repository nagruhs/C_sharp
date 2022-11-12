// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumFromMtoN(int m, int n)
{
    if (m == n) return n;
    if (m > n) return m + SumFromMtoN(m - 1, n);
    else return m + SumFromMtoN(m + 1, n);
}

Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"M = {m}; N = {n} -> {SumFromMtoN(m, n)}");