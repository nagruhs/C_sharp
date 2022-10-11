// // Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void Elochka(int a)
{
    int xa = Console.WindowWidth / 2, ya = 0;
    for (int i = 0; i != a; i++)
    {
        Console.SetCursorPosition(xa + i, ya + i);
        Console.WriteLine("*");
        Console.SetCursorPosition(xa - i, ya + i);
        Console.WriteLine("*");
        int j = 0;
        while (j < i)
        {
            Console.SetCursorPosition(xa - j, ya + i);
            Console.WriteLine("*");
            Console.SetCursorPosition(xa + j, ya + i);
            Console.WriteLine("*");
            j++;
        }
    }
}

Console.Clear();
Console.Write("Введите высоту елочки: ");
int a = int.Parse(Console.ReadLine()!);
Elochka(a);