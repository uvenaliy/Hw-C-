// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует массив
int[] GenArray(int arrayLength, int minNum, int maxNum)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i<arrayLength; i++)
    {
        array[i] = rnd.Next(minNum, maxNum);
    }
    return array;
}

// Метод печатает сгенерированный массив
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}

int arrayLength = ReadData("Введите длину массива:");
int min = ReadData("Введите нижнюю границу массива: ");
int max = ReadData("Введите верхнюю границу массива: ");

int[] array = GenArray(arrayLength, min, max);

PrintArray(array);

