string SetName()
{
    Console.WriteLine("Введите имя:");
    string userName = Console.ReadLine();
    return userName;
}
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