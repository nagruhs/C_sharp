// принимает 2 точки не равных нулю и выдает четверть

Console.Clear();

Console.Write("Введите икс: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите игрик: ");
int y = int.Parse(Console.ReadLine()!);

if (x>0)
{
    if(y>0)
    {
        Console.Write("первая");
    }
    else
    {
        Console.Write("четвертая");
    }
}
else
{
     if(y<0)
    {
        Console.Write("третья");
    }
    else
    {
        Console.Write("вторая");
    }
}