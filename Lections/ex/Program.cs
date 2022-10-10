// решение со строками
int a = 1234;
string str = a.ToString();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}
Console.Write($"{array.Sum()} ");

// арифметическое решение
int a = -1234;
int sum = 0;
while (a != 0)
{
    sum = sum + a % 10;
    a = a / 10;
}
Console.Write($"{sum} ");