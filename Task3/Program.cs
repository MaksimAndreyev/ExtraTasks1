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
    Console.WriteLine("Для перевода валюты введите исходную(рубли, доллары, евро), а затем на следующей строчке желаемую.");
    string input = Console.ReadLine().ToLower();
    switch(input)
    {
        case "стоп":
            flag = false;
            break;
        case "рубли":
            string input2 = Console.ReadLine().ToLower();
            switch(input2)
            {
                case "доллары":
                    dollars = ConvertFromRubles(rubles, dollars, DoToRu);
                    rubles = 0;
                    break;
                case "евро":
                    euros = ConvertFromRubles(rubles, euros, EuToRu);
                    rubles = 0;
                    break;
                default:
                    Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
                    break;
            }
            break;
        case "доллары":
            string input3 = Console.ReadLine().ToLower();
            switch(input3)
            {
                case "рубли":
                    rubles = ConvertToRubles(dollars, rubles, DoToRu);
                    dollars = 0;
                    break;
                case "евро":
                    euros = ConvertFromRubles(ConvertToRubles(dollars, rubles, DoToRu)-rubles, euros, EuToRu);
                    dollars = 0;
                    break;
                default:
                    Console.WriteLine("Ошибка конвертации. Проверьте ввод и повторите попытку.");
                    break;
            }
            break;
        case "евро":
            string input4 = Console.ReadLine().ToLower();
            switch(input4)
            {
                case "рубли":
                    rubles = ConvertToRubles(euros, rubles, EuToRu);
                    euros = 0;
                    break;
                case "доллары":
                    dollars = ConvertFromRubles(ConvertToRubles(euros, rubles, EuToRu)-rubles, dollars, DoToRu);
                    euros = 0;
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