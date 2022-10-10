Console.WriteLine("Введите трехзначное число.");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Не день недели");
    }
    else Console.WriteLine("Нет");
}
DayOfTheWeek(dayNumber);