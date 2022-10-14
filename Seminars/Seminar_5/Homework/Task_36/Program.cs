// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
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
int[] ArrayResult = GetArray(5, -99, 99);
int sum = SumNechetIndex(ArrayResult);

Console.WriteLine($"В массиве {String.Join(", ", ArrayResult)} сумма элементов на нечетных позициях индексов = {sum}");
