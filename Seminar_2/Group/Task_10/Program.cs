// задача выводит случайное число и показывает наибольшую цифру числа

Console.Clear();

int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max = 2;
}

Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
