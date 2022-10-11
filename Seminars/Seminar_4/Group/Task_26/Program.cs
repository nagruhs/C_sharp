// принимает число и выдает количество цифр 865

void Kolvo(int n)
{
    int i = 0;
    if (n == 0) i = 1;

    while (n != 0)
    {
        n = n / 10;
        i = i + 1;
    }
    Console.Write(i);
}


Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Kolvo(N);

