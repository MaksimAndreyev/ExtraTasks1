bool IsMovementPossible(int currentColumn, int currentRow, int moveColumn, int moveRow, string[,] maze)
{
    currentColumn += moveColumn;
    currentRow += moveRow;
    if (currentColumn == 10 && currentRow == 8)
    {
        return true;
    }
    if (maze[currentRow, currentColumn] == " ")
    {
        currentColumn -= moveColumn;
        currentRow -= moveRow;
        Console.SetCursorPosition(currentColumn+1, currentRow);
        Console.Write("\b");
        Console.Write(" ");
        return true;
    }
    else return false;
}


string[,] maze = new string[10, 10] {{"*", "*", "*", "*", "*", "*", "*", "*", "*", "*"},
                                     {"*", " ", " ", " ", " ", "*", "*", "*", "*", "*"},
                                     {"*", " ", "*", "*", " ", "*", "*", "*", "*", "*"},
                                     {"*", " ", " ", "*", " ", " ", " ", " ", " ", "*"},
                                     {"*", "*", "*", "*", " ", "*", " ", " ", " ", "*"},
                                     {"*", "*", " ", " ", " ", "*", " ", " ", " ", "*"},
                                     {"*", "*", " ", "*", "*", "*", " ", " ", " ", "*"},
                                     {"*", "*", " ", " ", " ", " ", "*", "*", "*", "*"},
                                     {"*", "*", "*", "*", "*", " ", " ", " ", " ", " "},
                                     {"*", "*", "*", "*", "*", "*", "*", "*", "*", "*"}};
int heroRow = 1;
int heroColumn = 1;
bool victory = false;
Console.Clear();
for (int i=0; i<10; i++)
{
    for (int j=0; j<10; j++)
    {
        Console.Write(maze[i, j]);
    }
    Console.WriteLine();
}
while (!victory)
{
    Console.SetCursorPosition(heroColumn+1, heroRow);
    Console.Write("\b");
    Console.Write("@");
    Console.SetCursorPosition(heroColumn, heroRow);
    Console.CursorVisible = false;
    var input = Console.ReadKey();
    switch (input.Key)
    {
        case System.ConsoleKey.DownArrow:
            if  (IsMovementPossible(heroColumn, heroRow, 0, 1, maze))   heroRow += 1;
            break;
        case System.ConsoleKey.UpArrow:
            if  (IsMovementPossible(heroColumn, heroRow, 0, -1, maze))  heroRow -= 1;
            break;
        case System.ConsoleKey.LeftArrow:
            if  (IsMovementPossible(heroColumn, heroRow, -1, 0, maze))  heroColumn -= 1;
            break;
        case System.ConsoleKey.RightArrow:
            if  (IsMovementPossible(heroColumn, heroRow, 1, 0, maze))   heroColumn += 1;
            break;
        case System.ConsoleKey.Escape:
            return;
    }
    if (heroColumn == 10 && heroRow == 8)   victory = true;
    Console.CursorVisible = false;
}
Console.Clear();
Console.WriteLine("Поздравляем, Вы победили!");