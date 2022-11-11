// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

int SumOfDigits(int n)
{
    if (n == 0)
        return 0;
    return (n % 10 + SumOfDigits(n / 10));
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел равна: {SumOfDigits(n)}");