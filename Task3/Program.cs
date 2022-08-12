float ConvertToRubles(float money, float balance, float rate)
{
    balance += (money * rate);
    return balance;
}


float ConvertFromRubles(float money, float balance, float rate)
{
    balance += (money / rate);
    return balance;
}


float rubles = 1000;
float dollars = 100;
float euros = 75;
float DoToRu = 60;
float EuToRu = 62;
bool flag = true;
while (flag == true)
{
    Console.WriteLine("Вас приветствует конвертер валют. Для окнчания работы введите \"стоп\"");
    Console.WriteLine($"Ваш баланс:\n{rubles} рублей\n{dollars} долларов\n{euros} евро");
    Console.WriteLine("Для перевода валюты введите исходную(рубли, доллары, евро), на следующей строчке желаемую, а затем количество.");
    string input = Console.ReadLine().ToLower();
    switch(input)
    {
        case "стоп":
            flag = false;
            break;
        case "рубли":
            string input2 = Console.ReadLine().ToLower();
            int amount = Convert.ToInt32(Console.ReadLine());
            while (amount > rubles || amount < 0)
            {
                Console.WriteLine("Неверное количество. Повторите ввод:");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            switch(input2)
            {
                case "доллары":
                    dollars = ConvertFromRubles(amount, dollars, DoToRu);
                    rubles -= amount;
                    break;
                case "евро":
                    euros = ConvertFromRubles(amount, euros, EuToRu);
                    rubles -= amount;
                    break;
                default:
                    Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
                    break;
            }
            break;
        case "доллары":
            string input3 = Console.ReadLine().ToLower();
            int amount2 = Convert.ToInt32(Console.ReadLine());
            while (amount2 > dollars || amount2 < 0)
            {
                Console.WriteLine("Неверное количество. Повторите ввод:");
                amount2 = Convert.ToInt32(Console.ReadLine());
            }
            switch(input3)
            {
                case "рубли":
                    rubles = ConvertToRubles(amount2, rubles, DoToRu);
                    dollars -= amount2;
                    break;
                case "евро":
                    euros = ConvertFromRubles(ConvertToRubles(amount2, rubles, DoToRu)-rubles, euros, EuToRu);
                    dollars -= amount2;
                    break;
                default:
                    Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
                    break;
            }
            break;
        case "евро":
            string input4 = Console.ReadLine().ToLower();
            int amount3 = Convert.ToInt32(Console.ReadLine());
            while (amount3 > euros || amount3 < 0)
            {
                Console.WriteLine("Неверное количество. Повторите ввод:");
                amount3 = Convert.ToInt32(Console.ReadLine());
            }
            switch(input4)
            {
                case "рубли":
                    rubles = ConvertToRubles(amount3, rubles, EuToRu);
                    euros -= amount3;
                    break;
                case "доллары":
                    dollars = ConvertFromRubles(ConvertToRubles(amount3, rubles, EuToRu)-rubles, dollars, DoToRu);
                    euros -= amount3;
                    break;
                default:
                    Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
                    break;
            }
            break;
        default:
            Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
            break;
    }
}