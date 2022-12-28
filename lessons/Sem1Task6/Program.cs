// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string? inputLine1 = Console.ReadLine();        //Считываем данные с консоли

if (inputLine1 != null)                           // проверяем, чтобы данные были не 
{
    int inputNumber1 = int.Parse( inputLine1);  // Изменяем введеные строки в целые числа
    if (inputNumber1 % 2 == 1 )
            {
                Console.WriteLine("Число " + inputNumber1 + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + inputNumber1 + "является: ЧЁТНЫМ");
            }
}