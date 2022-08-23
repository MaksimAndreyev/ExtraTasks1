string[][] AddName(string[][] names, string[] fullName)
{
    Array.Resize(ref names, names.Length+1);
    names[names.Length-1] = fullName;
    return names;
}


string[] AddTitle(string[] titles, string title)
{
    Array.Resize(ref titles, titles.Length+1);
    titles[titles.Length-1] = title;
    return titles;
}


int[] AddSalary(int[] salaries, int salary)
{
    Array.Resize(ref salaries, salaries.Length+1);
    salaries[salaries.Length-1] = salary;
    return salaries;
}


void PrintDossier(string[][] names, string[] titles, int[] salaries, int i)
{
    Console.WriteLine($"{names[i][0]} {names[i][1]} {names[i][2]} - {titles[i]} - {salaries[i]}");
}


void PrintDossiers(string[][] names, string[] titles, int[] salaries)
{
    for (int i=0; i<titles.Length; i++)
    {
        PrintDossier(names, titles, salaries, i);
    }
}


string[][] DeleteName(string[][] names, int index)
{
    string[][] newNames = new string[names.Length-1][];
    int j = 0;
    for (int i=0; i<names.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        newNames[j] = names[i];
        j++;
    }
    return newNames;
}


string[] DeleteTitle(string[] titles, int index)
{
    string[] newTitles = new string[titles.Length-1];
    int j = 0;
    for (int i=0; i<titles.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        newTitles[j] = titles[i];
        j++;
    }
    return newTitles;
}


int[] DeleteSalary(int[] salaries, int index)
{
    int[] newSalaries = new int[salaries.Length-1];
    int j = 0;
    for (int i=0; i<salaries.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        newSalaries[j] = salaries[i];
        j++;
    }
    return newSalaries;
}


bool FindBySurname(string[][] names, string[] titles, int[] salaries, string surname, bool noMatches)
{
    for (int i=0; i<names.Length; i++)
        {
            if (names[i][0] == surname)
                {
                    PrintDossier(names, titles, salaries, i);
                    noMatches = false;
                }
        }
    return noMatches;
}


bool FindBySalary(string[][] names, string[] titles, int[] salaries, int salary, bool noMatches)
{
    Console.WriteLine("Для отображения списка сотрудников с зарплатой больше указанной введите \"больше\".\nДля отображения списка сотрудников с зарплатой меньше указанной введите \"меньше\":");
    string moreOrLess = Console.ReadLine().ToLower();
    for (int i=0; i<salaries.Length; i++)
        {

            if (salaries[i] > salary && moreOrLess == "больше")
                {
                    PrintDossier(names, titles, salaries, i);
                    noMatches = false;
                }
            else if (salaries[i] < salary && moreOrLess == "меньше")
                {
                    PrintDossier(names, titles, salaries, i);
                    noMatches = false;
                }
        }
    return noMatches;
}


bool FindByTitle(string[][] names, string[] titles, int[] salaries, string title, bool noMatches)
{
    for (int i=0; i<titles.Length; i++)
        {
            if (titles[i] == title)
                {
                    PrintDossier(names, titles, salaries, i);
                    noMatches = false;
                }
        }
    return noMatches;
}


void FindDossier(string[][] names, string[] titles, int[] salaries)
{
    Console.WriteLine("Для поиска по фамилии введите \"по фамилии\".\nДля поиска по зарплате введите \"по зарплате\".\nДля поиска по должности введите \"по должности\":");
    string searchBy = Console.ReadLine().ToLower();
    bool noMatches = true;
    switch (searchBy)
    {
        case "по фамилии":
            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Console.ReadLine();
            noMatches = FindBySurname(names, titles, salaries, surname, noMatches);
            break;
        case "по зарплате":
            Console.WriteLine("Введите зарплату:");
            int salary = Convert.ToInt32(Console.ReadLine());
            noMatches = FindBySalary(names, titles, salaries, salary, noMatches);
            break;
        case "по должности":
            Console.WriteLine("Введите должность сотрудника:");
            string title = Console.ReadLine();
            noMatches = FindByTitle(names, titles, salaries, title, noMatches);
            break;
        default:
            Console.WriteLine("Некорректный параметр поиска.");
            noMatches = false;
            break;
    }
    if (noMatches) Console.WriteLine("Ничего не найдено.");
}


string[][] names = new string[][] {new string[] {"Иванов", "Иван", "Иванович"}};
string[] titles = {"кассир"};
int[] salaries = {25000};
bool flag = true;
string comand = "";
while (flag)
{
    Console.WriteLine("Для окончания работы введите \"стоп\".\nДля добавления досье введите \"добавить\".\nДля вывода всех досье введите \"вывод\".\nДля удаления досье введите \"удалить\".\nДля поиска досье введите \"поиск\":");
    comand = Console.ReadLine().ToLower();
    switch (comand)
    {
        case "стоп":
            flag = false;
            break;
        case "добавить":
            Console.WriteLine("Введите ФИО нового сотрудника:");
            string[] fullName = Console.ReadLine().Split();
            Console.WriteLine("Введите должность нового сотрудника:");
            string title = Console.ReadLine().ToLower();
            Console.WriteLine("Введите зарплату нового сотрудника:");
            int salary = Convert.ToInt32(Console.ReadLine());
            names = AddName(names, fullName);
            titles = AddTitle(titles, title);
            salaries = AddSalary(salaries, salary);
            break;
        case "вывод":
            PrintDossiers(names, titles, salaries);
            break;
        case "удалить":
            Console.WriteLine("Введите номер удаляемого досье:");
            int index = Convert.ToInt32(Console.ReadLine())-1;
            names = DeleteName(names, index);
            titles = DeleteTitle(titles, index);
            salaries = DeleteSalary(salaries, index);
            break;
        case "поиск":
            FindDossier(names, titles, salaries);
            break;
        default:
            Console.WriteLine("Ошибка ввода. Повторите попытку.");
            break;
    }
}