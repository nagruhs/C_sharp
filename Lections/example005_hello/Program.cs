Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Ура это же Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);

}