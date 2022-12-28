// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

int numN  = ReadData("Введите число N");
string outLine = LineBilder(numN, 1);
PrintData(" " , outLine);
outLine = LineBilder(numN, 2);
PrintData (" ", outLine);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод собирает строку
string LineBilder(int n, int pow)
{
    string line = string.Empty;
    for(int i=1; i<n; i++)
    {
        line = line + Math.Pow(i, pow) + " ";
    }

    line = line + Math.Pow(n, pow);
    return line;
}

// Метод выводит данные пользователя
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}
