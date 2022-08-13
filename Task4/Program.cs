int[] SetNumbers()
{
    string[] input = Console.ReadLine().Split();
    int[] newArray = new int[input.Length];
    for (int i=0; i<input.Length; i++)
    {
        newArray[i] = Convert.ToInt32(input[i]);
    }
    return newArray;
}


int[] AddToArray(int[] array, int number)
{
    int[] newArray = new int[array.Length+1];
    for (int i=0; i<array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[newArray.Length-1] = number;
    return newArray;
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


int[] Shuffle(int[] array)
{
    int[] newArray = new int[array.Length];
    int j = 0;
    for (int i=0; i<newArray.Length; i++)
    {
        j = new Random().Next(0, array.Length);
        newArray[i] = array[j];
        array = RemoveFromArray(array, j);
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
    Console.WriteLine("\nДля создания нового массива введите \"новый\", а на следующей строчке значения.");
    Console.WriteLine("Для добавления элемента введите \"добавить\", а на следующей строчке число.\nДля удаления элемента введите \"удалить\", а на следующей строчке индекс.\nДля перемешивания массива введите \"перемешать\".\nДля окончания работы введите \"стоп\"");
    string command = Console.ReadLine().ToLower();
    switch (command)
    {
        case "стоп":
            return;
        case "новый":
            array = SetNumbers();
            break;
        case "удалить":
            int index = Convert.ToInt32(Console.ReadLine());
            array = RemoveFromArray(array, index);
            break;
        case "добавить":
            int number = Convert.ToInt32(Console.ReadLine());
            array = AddToArray(array, number);
            break;
        case "перемешать":
            array = Shuffle(array);
            break;
        default:
            Console.WriteLine("Ошибка ввода. Повторите попытку.");
            break;
    }
}