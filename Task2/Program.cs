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


string password = "111";
string name = "Имя не задано";
while (true)
{
    Console.WriteLine("Введите что-нибудь:");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
}