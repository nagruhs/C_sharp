// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] DigitsToArray(string MyArray)
{
    MyArray = MyArray + ",";
    int count = 0;
    int j = 0;
    int length = MyArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (MyArray[i] == ',') count++; //по запятым считаю длину массива
    }
    int[] MyNewArray = new int[count];

    for (int i = 0; i < MyArray.Length; i++)
    {
        string TempArray = "";

        while (MyArray[i] != ',' && i < MyArray.Length)
        {
            TempArray += MyArray[i];
            i++;
        }
        MyNewArray[j] = Convert.ToInt32(TempArray);
        j++;
    }
    return MyNewArray;
}

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




Console.Write("Введите числа через запятую, например \"1, 2, 3, 4\" : ");
string array = Console.ReadLine()!;


int[] MyNewArray = DigitsToArray(array);
PrintArray(MyNewArray);