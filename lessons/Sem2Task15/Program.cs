﻿//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine() ?? "0");

//Создаем цикл, если выполняется условие 0<number<8
if((number > 0)&&(number < 8))
{
    Dictionary<int, string> dict = new Dictionary<int, string>
    {
        {1, "рабочий день"},
        {2, "рабочий день"},
        {3, "рабочий день"},
        {4, "рабочий день"},
        {5, "рабочий день"},
        {6, "выходной день"},
        {7, "выходной день"},
    };

//Выводим значение словаря по дню
Console.WriteLine(dict[number]);
}

else{
    //Выводим, если не выполняется условие
    Console.WriteLine("Это не день недели");
}