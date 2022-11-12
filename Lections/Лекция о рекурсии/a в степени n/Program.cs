// Вычислить а в степени n



//  int PowerFor(int a, int n)
//  {   int result = 1;
//      for (int i = 1; i <= n; i++) result *= a;
//      return result;
//  }
int PowerRec(int a, int n)
{   //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // то же что и ниже, но одной строкой через тернарный оператор
    if (n == 0) return 1; // решили что 0 в степени 0 это 1
    else return PowerRec(a, n - 1) * a;
}

//  int PowerRecMath(int a, int n) // лучшее решение через хитрожопую формулу
//  {
//      if (n == 0) return 1;
//      else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//      else return PowerRecMath(a, n - 1) * a;
// }


// Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10)); // 1024