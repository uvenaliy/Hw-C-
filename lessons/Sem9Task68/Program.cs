// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

//Чтение данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Функция Аккермана
int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    else
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
}


int m = ReadData("Введите неотрицательное число M: ");
int n = ReadData("Введите неотрицательное число N: ");
if (m >= 0 && n >= 0)
{
    PrintResult($"Функция Аккермана A({m},{n}) = {AckermannFunc(m, n)}");
}
else 
{
    PrintResult("Необходимо использовать неотрицательные числа");
}