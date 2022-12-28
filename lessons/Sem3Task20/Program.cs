// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

int X1 = ReadData("Введите координату X1");
int Y1 = ReadData("Введите координату Y1");
int X2 = ReadData("Введите координату X2");
int Y2 = ReadData("Введите координату Y2");

PrintData("Расстояние между точками: " , DistanceBetweenPoints(X1, Y1, X2, Y2));

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// метод находит расстояние между точками
double DistanceBetweenPoints(double x1, double x2, double y1, double y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    return distance;
}

// Метод выводит данные пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
