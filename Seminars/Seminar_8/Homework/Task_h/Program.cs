// Задача "со звездочкой": Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5
// Нельзя использовать встроенные функции библиотеки Math!


int Sqrt(int x)
{
    int temp = 1;
    int result = 0;

    if (x == 0) return result = 0;
    if (x == 1) return result = 1;
    while (x > 1)
    {
        x = x - temp;
        temp += 2;
        if (x >= 0) result++;
    }
    return result;
}

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sqrt(x));