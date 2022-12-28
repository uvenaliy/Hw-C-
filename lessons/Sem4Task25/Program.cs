// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B


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


// Метод, вычисляющий возведение в степень
int Pow (int a, int b)
{
    int res = 1;
    for(int i = 1; i<=b; i++)
    {
        res = a*res;
    }
    return res;
}

int num1 = ReadData("Введите число A: ");
int num2 = ReadData("Введите число B: ");
int res = Pow(num1, num2);
PrintData("Число A возведененное в степень B равно: " + res);