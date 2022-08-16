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


void PrintDossiers(string[][] names, string[] titles, int[] salaries)
{
    for (int i=0; i<titles.Length; i++)
    {
        Console.WriteLine($"{names[i][0]} {names[i][1]} {names[i][2]} - {titles[i]} - {salaries[i]}");
    }
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
    }
}