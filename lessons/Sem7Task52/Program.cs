// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 1, 16);
Print2DArrayColor(arr2D);
double[] avg = AverageColumn(arr2D);
Console.WriteLine();
PrintData(avg);

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

// Метод вычисляет среднее арифметическое
double[] AverageColumn(int[,] arr2D)
{
    double[] avg = new double[arr2D.GetLength(1)];
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            avg[j] += arr2D[i, j];
        }
        avg[j] = avg[j] / arr2D.GetLength(0);
    }
    return avg;
}

// // Метод печатает итоговый одномерный массив из средних арифметических
void PrintData(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",  ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
