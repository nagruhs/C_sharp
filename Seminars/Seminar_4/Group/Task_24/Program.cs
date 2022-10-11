// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

int GetSum(int A)
{
    int sum = 0;

    for (int i = 0; i <= A; i++)
    {
        sum += i; // sum = sum + i;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите А: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n));