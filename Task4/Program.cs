int[] AddToArray(int[] array, int number)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length-1] = number;
    return array;
}


int[] RemoveFromArray(int[] array, int index)
{
    int[] newArray = new int[array.Length-1];
    int j = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        newArray[j] = array[i];
        j++;
    }
    return newArray;
}


int[] array = new int[] {1, 2, 3, 4, 5};
while (true)
{
    Console.WriteLine("Массив:");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\nДля добавления элемента введите \"добавить\", а на следующей строчке число.\nДля удаления элемента введите \"удалить\", а на следующей строчке индекс.\nДля окончания работы введите \"стоп\"");
    string command = Console.ReadLine().ToLower();
    switch (command)
    {
        case "стоп":
            return;
        case "удалить":
            int index = Convert.ToInt32(Console.ReadLine());
            array = RemoveFromArray(array, index);
            break;
        case "добавить":
            int number = Convert.ToInt32(Console.ReadLine());
            array = AddToArray(array, number);
            break;
        default:
            Console.WriteLine("Ошибка ввода. Повторите попытку.");
            break;
    }
}