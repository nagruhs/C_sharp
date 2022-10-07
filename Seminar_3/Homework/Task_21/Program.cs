//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double rast(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}


Console.Clear();

Console.Write("Введите первую координату точки А: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату точки А: ");
int a2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату точки А: ");
int a3 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первую координату точки В: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату точки В: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату точки В: ");
int b3 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние: {rast(a1, a2, a3, b1, b2, b3):f2}");
