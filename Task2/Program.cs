void WriteName(string name, string password)
{
    Console.WriteLine("Для вывода имени введите пароль:");
    string input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine(name);
    }
    else
    {
        Console.WriteLine("Неверный пароль");
    }
}


while (true)
{
    Console.WriteLine("Введите что-нибудь:");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
}