// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, вычисляющий сумму цифр в числе
int SumDigit(int num)
{
    int res = 0;
    while(num > 0)
    {
        res+=num%10;
        num = num/10;
    }
    return res;
}

int num = ReadData("Введите число: ");
int sum = SumDigit(num);
PrintData("Сумма цифр числа " + num + " равна " + sum);
