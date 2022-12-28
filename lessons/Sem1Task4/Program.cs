//// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
string? inputLine1 = Console.ReadLine();                 
string? inputLine2 = Console.ReadLine();                         //Считываем данные с консоли
string? inputLine3 = Console.ReadLine();                  

if (inputLine1!=null && inputLine2!=null && inputLine3!=null)    // проверяем, чтобы данные были не пустыми
{
    int inputNumber1 = int.Parse( inputLine1);           
    int inputNumber2 = int.Parse( inputLine2);                   // Изменяем введеные строки в целые числа
    int inputNumber3 = int.Parse( inputLine3);
   
    int inputMax = inputNumber1;

    
    if (inputNumber2 > inputMax)                      //Проверка условий, что второе число больше максимального
       {
          Console.WriteLine(inputMax = inputNumber2);  //присваивание максиального числа
       }
    if (inputNumber3 > inputMax)                      //Проверка условий, что третие число больше максимального
       {
        Console.WriteLine(inputMax = inputNumber3);  //присваивание максиального числа 
       }

    Console.WriteLine(inputMax + " максимальное число ");

}