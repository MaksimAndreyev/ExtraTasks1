string SetPassword()
{
    Console.WriteLine("Задайте пароль:");
    string userPassword = Console.ReadLine();
    return userPassword;
}


string password = "111";
while (true)
{
    Console.WriteLine("Введите что-нибудь:");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
}