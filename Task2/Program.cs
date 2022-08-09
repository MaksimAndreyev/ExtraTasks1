<<<<<<< HEAD
﻿string SetName()
{
    Console.WriteLine("Введите имя:");
    string userName = Console.ReadLine();
    return userName;
}
string name = "Имя не задано";
=======
﻿void Help()
{
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль (по умоляанию - 111)");
    Console.WriteLine("Exit – выход");
    Console.WriteLine("WriteName – вывести имя после ввода пароля");
}


>>>>>>> help
while (true)
{
    Console.WriteLine("Введите что-нибудь:");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
}