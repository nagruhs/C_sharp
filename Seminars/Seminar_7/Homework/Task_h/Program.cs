// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

//метод перевода римских чисел в десятичные арабские.
int RomanToArab(string roman)
{
    int result = 0;
    int[] tempArray = new int[roman.Length + 1]; // временный массив с размером +1, чтобы в цикле сравнения работало [i+1]

    for (int i = 0; i < tempArray.Length - 1; ++i) // цикл замены римских на арабские аналоги
    {
        if (roman[i] == 'I') tempArray[i] = 1;
        if (roman[i] == 'V') tempArray[i] = 5;
        if (roman[i] == 'X') tempArray[i] = 10;
        if (roman[i] == 'L') tempArray[i] = 50;
        if (roman[i] == 'C') tempArray[i] = 100;
        if (roman[i] == 'D') tempArray[i] = 500;
        if (roman[i] == 'M') tempArray[i] = 1000;
    }

    for (int i = 0; i < tempArray.Length - 1; i++) // арифметика для вычисления нашего числа
    {
        if (tempArray[i] >= tempArray[i + 1]) result += tempArray[i];
        else
        {
            result += tempArray[i + 1] - tempArray[i];
            i++;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите римское число (например: \"MCMXCIV\" или \"MDCXCV\")");
string number = Console.ReadLine()!;
Console.WriteLine($"ответ {RomanToArab(number)}");