// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

// подсказка решать через стек



// метод проверки скобочной последовательности
bool CheckStr(string myString)
{
    Stack<char> stack = new Stack<char>(); // создаю стек

    bool CheckStack(char a, char b) // метод проверки пригодится позже
    {
        return
        a == ')' && b == '(' ||
        a == ']' && b == '[' ||
        a == '}' && b == '{';
    }

    for (int i = 0; i < myString.Length; i++) // обхожу строку и пушу все скобки в стек, попутно проверяя каждую пару
    {
        if (myString[i] == '(') stack.Push(myString[i]);
        if (myString[i] == '[') stack.Push(myString[i]);
        if (myString[i] == '{') stack.Push(myString[i]);
        if (myString[i] == '}') stack.Push(myString[i]);
        if (myString[i] == ']') stack.Push(myString[i]);
        if (myString[i] == ')') stack.Push(myString[i]);
        if (stack.Count > 1)
        {
            if (CheckStack(stack.Pop(), stack.Peek())) stack.Pop(); // Pop - чтение с удалением. Peek - без удаления.
            else return false; // если совпали, то удаляю оба иначе false
        }
    }
    if (stack.Count == 0) return true; // если прошел всю строку и удалил все из стека, то true
    else return false;
}

Console.Clear();
Console.Write("Введите строку со скобками вида {}, (), []: ");
string myString = (Console.ReadLine()!);
Console.Clear();
if (CheckStr(myString)) Console.WriteLine($"\" {myString} \" -> правильная скобочная последовательность");
else Console.WriteLine($"\" {myString} \" -> неправильная скобочная последовательность");

