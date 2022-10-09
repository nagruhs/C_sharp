Console.Write("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine()!);
int result = a1 % a2;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.Write(result);
}