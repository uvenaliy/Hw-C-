 // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string? inputLine1 = Console.ReadLine();                  //Считываем данные с консоли
string? inputLine2 = Console.ReadLine();

if (inputLine1!=null && inputLine2!=null)                 // проверяем, чтобы данные были не пустыми
{
    int inputNumber1 = int.Parse( inputLine1);            // Изменяем введеные строки в целые числа
    int inputNumber2 = int.Parse( inputLine2);
   
    if (inputNumber1==inputNumber2)
    {
        Console.WriteLine("Числа равны");                 //Проверка на равенство
    }
    else
    {
       if (inputNumber1 > inputNumber2)                   //Проверка условий, что первое число больше второго
       {
          Console.WriteLine(inputNumber1 + " больше " + inputNumber2);
       }
       else
       {
        Console.WriteLine(inputNumber1 + " меньше " + inputNumber2);
       }
    }   
}
    