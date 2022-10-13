// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Метод создания массива c рандомными числами (minlenght - минимальная длина массива, maxlenght - максимальная длина массива, mindigit - минимальное число в значении, maxdigit - максимальное число в значении)

int[] RandomArr(int minlenght, int maxlenght, int mindigit, int maxdigit)
{
    int[] array = new int[new Random().Next(minlenght, maxlenght + 1)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(mindigit, maxdigit + 1);
    }
    return array;
}


// вывод массива на экран
void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
}


// метод подсчета суммы элементов на нечетных позициях
int SumNechetIndex(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}


// программа
Console.Clear();
int[] ArrayResult = RandomArr(5, 10, -99, 99);
int sum = SumNechetIndex(ArrayResult);

Console.Write("В массиве: ");
PrintArray(ArrayResult);
Console.WriteLine($" сумма элементов на нечетных позициях = {sum}");
