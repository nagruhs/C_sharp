// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Pow(int a, int b)
{
    int product = 1;
    int kostyl = 1;  //костыль без использования Math на случай, если ввели отрицательное b
    if (b < 0) kostyl = -1;

    for (int i = 0; i != b * kostyl; i++)
    {
        product = product * a;
    }
    Console.WriteLine($"число {a} в степени {b} = {product}");
}

Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Pow(a, b);

