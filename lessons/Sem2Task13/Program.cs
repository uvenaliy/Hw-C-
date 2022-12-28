//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number>99)                                       //Создаем условие, чтобы в числе было минимум три цифры
{ 
    int length = (int)Math.Log10(number) + 1;
    int index = 0;                                    //Находим количество цифр в числе
    int thirdDigit = number;

    //Делаем деление числа на 10 (length-3) раз, чтобы осталось три цифры в числе
    while(index < length - 3)
{
    thirdDigit = thirdDigit/10;
    index++;
}

//находим третью цифру остатком деления на 10
thirdDigit = thirdDigit % 10;

//Выводим третье число
Console.WriteLine(thirdDigit + " является третьей цифрой числа " + number);
}

else
{
    //Выводим если в числе меньше трех цифр
    Console.WriteLine("Число двузначное, третьей цифры нет");
}



