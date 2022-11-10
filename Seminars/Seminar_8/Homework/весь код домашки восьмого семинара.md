// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//  метод создания двумерного массива
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Random2dArray;
}

// метод вывода массива на печать
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

// метод упорядочивания строк двумерного массива по убыванию
int[,] Sort2DArrayRowsFromMaxtoMin(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            for (int nextColumn = column + 1; nextColumn < inArray.GetLength(1); nextColumn++)
            {
                if (inArray[row, column] < inArray[row, nextColumn])
                {
                    int temp = inArray[row, column];
                    inArray[row, column] = inArray[row, nextColumn];
                    inArray[row, nextColumn] = temp;
                }
            }
        }
    }
    return inArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
Print2dArray(array);
Console.WriteLine();
int[,] result = Sort2DArrayRowsFromMaxtoMin(array);
Print2dArray(result);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//  метод создания двумерного массива
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Random2dArray;
}

// метод вывода массива на печать
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

// Функция вывода номера строки с наименьшей суммой элементов 
void NumberOfRowsMinSum(int[,] array)
{
    int tempSum;
    int minSum = 0;
    int result = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        minSum += array[0, column];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        tempSum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            tempSum += array[row, column];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            result = row;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
Print2dArray(array);
Console.WriteLine();
NumberOfRowsMinSum(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//  метод создания двумерного массива с числами от 1 до 5
int[,] GetInt2dArray(int rows, int columns)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(1, 6);
        }
    }
    return Random2dArray;
}

// метод вывода массива на печать
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

// метод перемножения двух матриц, если это возможно
int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine("Эти матрицы нельзя перемножить");
        return new int[0, 0]; // выдаст сообщение и вроде как всё
        // Environment.Exit(0); // выйдет из программы
        // return resultArray; // выдаст сообщение и массив с нулями
    }
    for (int row = 0; row < resultArray.GetLength(0); row++)
    {
        for (int column = 0; column < resultArray.GetLength(1); column++)
        {
            int sum = 0;
            for (int i = 0; i < firstArray.GetLength(1); i++)
            {
                sum += firstArray[row, i] * secondArray[i, column];
            }
            resultArray[row, column] = sum;
        }
    }
    Console.WriteLine("результат:");
    return resultArray;
}


Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом массиве: ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] firstArray = GetInt2dArray(rows1, columns1);
Console.Write("Введите количество строк во втором массиве: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во втором массиве: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] secondArray = GetInt2dArray(rows2, columns2);

Print2dArray(firstArray);
Console.WriteLine();
Print2dArray(secondArray);

Console.WriteLine();
Print2dArray(MultiplyMatrix(firstArray, secondArray));


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

//  метод создания двумерного массива
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Random2dArray;
}

// метод вывода массива на печать
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

// метод поиска минимального значения и его индексов
int[] SearchMinIndexes(int[,] array)
{
    int[] position = new int[2]; // результат запишу в одномерный массив с двумя значениями
    int temp = array[0, 0]; // за минимум беру верхнее левое значение
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0] = i;
                position[1] = j;
                temp = array[i, j];
            }
        }
    }
    Console.WriteLine($"Наименьший элемент: {temp}");
    // Console.WriteLine($"с индексами {String.Join(" и ", position)} (помним, что индексы считаются с нуля)");
    return position;
}

// метод удаления строки и столбца из массива
int[,] RemoveRowColumn(int[,] array, int[] position)
{
    if (array.GetLength(0) == 1 || array.GetLength(1) == 1)
        return new int[0, 0]; //если изначальный массив был 1х1, то возвращаю "пустоту"

    int[,] newArrray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newArrray.GetLength(0); i++)
    {
        for (int j = 0; j < newArrray.GetLength(1); j++)
        {
            if (i < position[0] && j < position[1])
                newArrray[i, j] = array[i, j];
            else if (i < position[0] && j >= position[1])
                newArrray[i, j] = array[i, j + 1];
            else if (i >= position[0] && j < position[1])
                newArrray[i, j] = array[i + 1, j];
            else
                newArrray[i, j] = array[i + 1, j + 1];
        }
    }
    return newArrray;
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
Print2dArray(array);
Console.WriteLine();

int[] tempArray = SearchMinIndexes(array);
Console.WriteLine();
int[,] result = RemoveRowColumn(array, tempArray);
Console.WriteLine("на выходе получим следующий массив:");
Print2dArray(result);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//  метод создания трехмерного массива
int[,,] GetInt3dArray(int a, int b, int c)
{
    int[,,] array3D = new int[a, b, c];
    int[] temp = new int[a * b * c]; // будем проверять и заполнять 3D массив с помощью одномерного
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100); // возможно 90 уникальных значений
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j]) // проверка уникальности значений
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; // заполнение 3D массива
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
    return array3D;
}

// метод вывода массива на печать
void Print3dArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива (X x Y x Z): ");
Console.WriteLine();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine()!);

if (x * y * z > 90) Console.WriteLine("Вы ввели слишком большой массив, в этой задаче нам это не нужно");
else
{
    int[,,] array = GetInt3dArray(x, y, z);
    Print3dArray(array);
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// метод заполнения квадратного массива 4 на 4 (по условию пользователь не вводит никакие данные)
int[,] FillSqrArray()
{
    int size = 4;
    int[,] newArray = new int[size, size];
    int row = 0;
    int column = 0;

    for (int temp = 1; temp <= size * size; temp++)
    {
        newArray[row, column] = temp;
        if (row <= column + 1 && row + column < size - 1) column++;
        else if (row < column && row + column >= size - 1) row++;
        else if (row >= column && row + column > size - 1) column--;
        else row--;
    }
    return newArray;
}

// метод вывода массива на печать
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

Console.Clear();
Print2dArray(FillSqrArray());


// Задача "со звездочкой": Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5
// Нельзя использовать встроенные функции библиотеки Math!


int Sqrt(int x)
{
    int temp = 1;
    int result = 0;

    if (x == 0) return result = 0;
    if (x == 1) return result = 1;
    while (x > 1)
    {
        x = x - temp;
        temp += 2;
        if (x >= 0) result++;
    }
    return result;
}

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sqrt(x));