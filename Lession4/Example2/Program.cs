// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = Input("Введите число ");
int arreyLenght = Convert.ToString(number).Length;
int remainder = 0;
int result = 0;

for (int i = 0; i < arreyLenght; i++)
{
    remainder = number - number % 10;
    result = result + (number - remainder);
    number = number / 10;
}

Console.Write(result);



int Input(string numbers)
{
    Console.Write($"{numbers}");
    return Convert.ToInt16(Console.ReadLine());
}