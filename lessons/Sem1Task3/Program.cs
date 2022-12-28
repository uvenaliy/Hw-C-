string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    // string[] dayWeek = new string[7];
    // dayWeek[0] = "monday";
    // dayWeek[1] = "tuesday";
    // dayWeek[2] = "wednesday";
    // dayWeek[3] = "thursday";
    // dayWeek[4] = "friday";
    // dayWeek[5] = "saturday";
    // dayWeek[6] = "sunday";

    int inputNumber = int.Parse(inputLine);

    // string outDayWeek = dayWeek[inputNumber-1];

    string outDayWeek = string.Empty;
    switch (inputNumber)
    {
        case 1: outDayWeek = "monday"; break;
        case 2: outDayWeek = "tuesday"; break;
        case 3: outDayWeek = "wednesday"; break;
        case 4: outDayWeek = "thursday"; break;
        case 5: outDayWeek = "friday"; break;
        case 6: outDayWeek = "saturday"; break;
        case 7: outDayWeek = "sunday"; break;
        default: outDayWeek = "it's not day week"; break;
    }

    Console.WriteLine(outDayWeek);
}
