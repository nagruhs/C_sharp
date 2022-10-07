// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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


int A = b1 - a1;
int B = b2 - a2;
int C = b3 - a3;

double result = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние: {result - result % 0.01}");