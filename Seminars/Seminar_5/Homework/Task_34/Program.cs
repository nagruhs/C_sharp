// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод создания массива длиной от 5 до 10 с рандомными трехзначными числами в значениях
int[] RandomArr()
{
    int[] array = new int[new Random().Next(5, 11)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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


// метод подсчета количества четных чисел
int Count(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


// программа
Console.Clear();
int[] ArrayResult = RandomArr();
int count = Count(ArrayResult);

Console.WriteLine($"В массиве:");
PrintArray(ArrayResult);
Console.WriteLine($" количество четных чисел = {count}");
