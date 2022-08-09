string message = "Шкаф продан, могу предложить никелированную кровать с тумбочкой.";
string password = "у вас продаётся славянский шкаф?";
int attempt = 3;
while (attempt != 0)
{
    Console.WriteLine("Введите пароль:");
    string input = Console.ReadLine().ToLower();
    if (input == password)
    {
        Console.WriteLine(message);
        break;
    }
    else
    {
        Console.WriteLine("Неверно. Попробуйте ещё раз.");
        attempt--;
    }
}