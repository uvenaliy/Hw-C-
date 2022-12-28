// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int number = ReadData("Введите пятизначное число: ");
bool result = PalindromeTest(number);
PrintData(result);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод проверки является ли число палиндромом
bool PalindromeTest (int number)
{
    bool result = false;
    if ((number/10000==number%10)&&((number/1000)%10==(number/10)%10)) result = true;
    return result;
}

// Метод выводит данные пользователя
void PrintData(bool result)
{
    Console.WriteLine(result);
}
