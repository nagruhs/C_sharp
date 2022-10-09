// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void polindrom(int number)
{
    if (number / 10000 == number % 10 && number / 1000 - number / 10000 * 10 == (number % 100) / 10)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет или неверный формат числа");
    }
}

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
polindrom(n);

