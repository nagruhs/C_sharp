// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (Math.Abs(number) < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    if (Math.Abs(number) > 999)
        while (Math.Abs(number) > 999)
        {
            number = number / 10;
        }
    Console.Write(Math.Abs(number) % 10);
}
