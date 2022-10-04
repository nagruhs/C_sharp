// принимает число и проверяет кратно ли оно 7 и 23


Console.Clear();

Console.Write("Введите число: ");
int a1 = int.Parse(Console.ReadLine()!);

if (a1 % 7 == 0 && a1 % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}