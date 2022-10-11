//  Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
int Proizv(int N)

{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result *= i;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Proizv(n));