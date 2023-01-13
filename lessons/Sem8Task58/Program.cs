// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int row1 = ReadData("Введите количество строк первой матрицы ");
int column1 = ReadData("Введите количество столбцов первой матрицы ");
int row2 = ReadData("Введите количество строк второй матрицы ");
int column2 = ReadData("Введите количество столбцов второй матрицы ");
int[,] arr2D1 = Fill2DArray(row1, column1, 1, 9);
int[,] arr2D2 = Fill2DArray(row2, column2, 1, 9);

Print2DArrayColor(arr2D1);
Console.WriteLine();
Print2DArrayColor(arr2D2);
Console.WriteLine("Произведение двух матриц: ");
int[,] result = CalcMatrix(arr2D1, arr2D2);
Print2DArrayColor(result);

// Метод читает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод выводит цветной двумерный массив
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

// Метод находит произведение двух матриц
int[,] CalcMatrix(int[,] matrix1, int[,] matrix2)
{
    if ((matrix1.GetLength(1) != matrix2.GetLength(1)) && (matrix1.GetLength(0) != matrix2.GetLength(1))) throw new Exception("Невозможно найти произведение");
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
    }
    return result;
}

