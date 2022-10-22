// Задача 50. Напишите программу, которая на вход принимает число, и выводит его, показывая что данный элемент есть, либо что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// метод создает двумерный массив со случайным количеством строк, столбцов и значений:
int[,] Get2dRandomArray()
{
    int m = new Random().Next(3, 11);
    int n = new Random().Next(3, 11);
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 11);
        }
    }
    return inArray;
}

// метод печати двумерного массива:
void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

// метод поиска числа в массиве
void FindNumIn2dArray(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                Console.WriteLine($"{number} - такое число в массиве есть.");
                Console.WriteLine($"Смотри столбец номер {j + 1} и строку номер {i + 1}.");
                return;
            }
        }
    }
    Console.WriteLine($"{number} - такого числа в массиве нет");
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] myArray = Get2dRandomArray();
Print2dArray(myArray);
Console.WriteLine();
FindNumIn2dArray(myArray, number);
