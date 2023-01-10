// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int x = ReadData("Введите индекс строки: ");
int y = ReadData("Введите индекс столбца: ");
int[,] arr2D = Fill2DArray(row, column, 1, 50);
Print2DArrayColor(arr2D);
int element = SearchElement(arr2D, x, y);
if (element == -1) PrintData("Нет элемента массива с указанными индексами");
else PrintData("Заданным индексам элемента массива соответствует значение: " + element);

// Метод читает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}


// Метод выводит цветной двумерный массив
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }

}

// Печать результата
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод ищет значение элемента по его позиции в массиве
int SearchElement(int[,] array, int x, int y)
{
    int element = -1;
    if (x < array.GetLength(0))
    {
        if (y < array.GetLength(1))
        {
            element = array[x, y];
        }
    }
    return element;
}

