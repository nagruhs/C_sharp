// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i * i}");
        if (i != num) Console.Write(", ");
    }
}


Console.Clear();

Console.Write("Введите число не менее 1: ");
int N = int.Parse(Console.ReadLine()!);

cub(N);



