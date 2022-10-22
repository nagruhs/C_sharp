// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

//метод перевода римских чисел в десятичные арабские.
int RomanToArab(string roman)
{
    int result = 0;
    int[] tempArray = new int[roman.Length];

    for (int i = 0; i < tempArray.Length; ++i)
    {
        if (roman[i] == 'I') tempArray[i] = 1;
        else if (roman[i] == 'V') tempArray[i] = 5;
        else if (roman[i] == 'X') tempArray[i] = 10;
        else if (roman[i] == 'L') tempArray[i] = 50;
        else if (roman[i] == 'C') tempArray[i] = 100;
        else if (roman[i] == 'D') tempArray[i] = 500;
        else if (roman[i] == 'M') tempArray[i] = 1000;
        else tempArray[i] = 0; //для последующей проверки корректности ввода
    }

    if (tempArray.Length == 1)
    {
        result = tempArray[tempArray.Length - 1]; //проверка на случай если ввели только одну цифру.
        return result;
    }

    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] == 0) //проверка корректности ввода
        {
            Console.WriteLine("Ошибка ввода");
            return result = 0;
        }
        if (i + 1 < tempArray.Length) //далее идет арифметика для подсчета конечного результата
        {
            if (tempArray[i] >= tempArray[i + 1])
            {
                result += tempArray[i];
            }
            else
            {
                result += tempArray[i + 1] - tempArray[i];
                i++;
            }
        }
        else if (i == tempArray.Length - 1) result += tempArray[i];
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите римское число (например: \"MCMXCIV\")");
string number = Console.ReadLine()!;
Console.WriteLine($"ответ {RomanToArab(number)}");