string SetName()
{
    Console.WriteLine("Введите имя:");
    string userName = Console.ReadLine();
    return userName;
}


void Help()
{
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль (по умолчанию - 111)");
    Console.WriteLine("Exit – выход");
    Console.WriteLine("WriteName – вывести имя после ввода пароля");
}


string SetPassword()
{
    Console.WriteLine("Задайте пароль:");
    string userPassword = Console.ReadLine();
    return userPassword;
}


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


string password = "111";
string name = "Имя не задано";
while (true)
{
    Console.WriteLine("Введите команду (чтобы получить список команд введите Help):");
    string input = Console.ReadLine();
    if (input == "Help")
    {
        Help();
    }
    else if (input == "SetName")
    {
        name = SetName();
    }
    else if (input == "SetPassword")
    {
        password = SetPassword();
    }
    else if (input == "WriteName")
    {
        WriteName(name, password);
    }
    else if (input == "Exit")
    {
        break;
    }
}