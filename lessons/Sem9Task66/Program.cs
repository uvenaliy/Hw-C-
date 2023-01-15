// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

//Чтение данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintData(int res)
{
    Console.WriteLine(res);
}

// Метод нахождения суммы
int SumMNRec(int m, int n)
{
    if (m >= n) return n;
    int outLine = m + SumMNRec(m + 1, n);
    return outLine;
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int result = 0;
if (m < n) result = SumMNRec(m, n);
else result = SumMNRec(n, m);
PrintData(result);