// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8


int PowerRec(int a, int b)
{   //return b == 0 ? 1 : PowerRec(a, n - 1) * a; // то же что и ниже, но одной строкой через тернарный оператор
    if (b == 0) return 1; // 0 в степени 0 это 1
    else return PowerRec(a, b - 1) * a;
}

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Ответ: {PowerRec(a, b)}");