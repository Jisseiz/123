Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.Write("Да");
    }
    else Console.Write("Нет");
}

CheckNumber(number);