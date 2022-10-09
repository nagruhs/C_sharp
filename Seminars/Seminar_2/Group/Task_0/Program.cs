// Console.Clear();
// int max;

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int number3 = int.Parse(Console.ReadLine()!);

// if (number1 > number2)
// {
//     max = number1;
// }
// else
// {
//     max = number2;
// }
// if (number3 > max)
// {
//     max = number3;
// }

// Console.Write($"Число {max} больше всех введенных чисел");


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
