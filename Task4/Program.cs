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


int[] RemoveNumbers(int[] array, int[] deleteList)
{
    foreach (int element in deleteList)
    {
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] == element)
            {
                array = RemoveFromArray(array, i);
            }
        }
    }
    return array;


}
int[] AddToArray(int[] array, int[] numbers)
{
    int[] newArray = new int[array.Length+numbers.Length];
    for (int i=0; i<array.Length; i++)
    {
        newArray[i] = array[i];
    }
    int j = 0;
    for (int i=array.Length; i<newArray.Length; i++)
    {
        newArray[i] = numbers[j];
        j++;
    }
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


void Numbers(int[] array)
{
    Console.WriteLine("Массив:");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void Sum(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        sum += element;
    }
    Console.WriteLine(sum);
}


int[] array = new int[0];
while (true)
{
    Console.WriteLine("Для отображения массива введите \"показать\".\nДля вывода суммы элементов массива введите \"сумма\".");
    Console.WriteLine("Для создания нового массива введите \"новый\", а на следующей строчке значения.\nДля удаления конкретных чисел введите \"убрать\", а на следующей строчке значения.");
    Console.WriteLine("Для добавления элементов введите \"добавить\", а на следующей строчке числа.\nДля удаления элемента введите \"удалить\", а на следующей строчке индекс.\nДля перемешивания массива введите \"перемешать\".\nДля окончания работы введите \"стоп\"");
    string command = Console.ReadLine().ToLower();
    switch (command)
    {
        case "стоп":
            return;
        case "показать":
            Numbers(array);
            break;
        case "сумма":
            Sum(array);
            break;
        case "новый":
            array = SetNumbers();
            break;
        case "убрать":
            int[] deleteList = SetNumbers();
            array = RemoveNumbers(array, deleteList);
            break;
        case "удалить":
            int index = Convert.ToInt32(Console.ReadLine());
            array = RemoveFromArray(array, index);
            break;
        case "добавить":
            int[] numbers = SetNumbers();
            array = AddToArray(array, numbers);
            break;
        case "перемешать":
            array = Shuffle(array);
            break;
        default:
            Console.WriteLine("Ошибка ввода. Повторите попытку.");
            break;
    }
}