// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число не менее 1: ");
int num = int.Parse(Console.ReadLine()!);
int index = 1;

while (index <= num)
{
    Console.Write($"{index * index * index}, ");
    index++;
}