// Факториал числа

DateTime dt = DateTime.Now;


// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }




int FactorialRec(int n) // хорошо бы описать и ноль еще т.к. факториал 0 это 1
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

// Console.WriteLine(FactorialFor(30)); // 3628800
Console.WriteLine(FactorialRec(30)); // 3628800


Console.Clear();
Console.WriteLine($"время выполнения {(DateTime.Now - dt).TotalMilliseconds} милисекунд");
Console.WriteLine();
