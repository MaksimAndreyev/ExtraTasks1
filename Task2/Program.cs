void Help()
{
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль (по умоляанию - 111)");
    Console.WriteLine("Exit – выход");
    Console.WriteLine("WriteName – вывести имя после ввода пароля");
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