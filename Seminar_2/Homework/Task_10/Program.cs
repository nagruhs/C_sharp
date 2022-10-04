// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if ((Math.Abs(number) < 100) || (Math.Abs(number) > 999))
//погуглил, вроде так ^ находим модуль, вроде это уместно
{
    Console.Write("Ввели не трехзначное число");
}
else
{
    int result = (number / 10) % 10;
    Console.Write($"Вот наша цифра:{Math.Abs(result)}");
}