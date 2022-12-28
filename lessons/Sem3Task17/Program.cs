//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка

// 1 этап Ввод данных
//Console.Write("Введите координату X: ");
//int coordX = int.Parse(Console.ReadLine()?? "0");

//Console.Write("Введите координату Y: ");
//int coordY = int.Parse(Console.ReadLine()?? "0");


int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод определяет четверть по координатам точки
void PrintQutertest()
{
    if(coordX>0&&coordY>0) Console.Write("Точка в четверти 1");
    if(coordX>0&&coordY<0) Console.Write("Точка в четверти 2");
    if(coordX<0&&coordY<0) Console.Write("Точка в четверти 3");
    if(coordX<0&&coordY>0) Console.Write("Точка в четверти 4");
}

PrintQutertest();