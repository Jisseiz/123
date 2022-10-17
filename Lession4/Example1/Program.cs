//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int number = Input("Введите число ");
int degree = Input("Введите степень ");
int result = number;

for (int i = 1; i < degree; i++)
{
    result = result * number;
}

Console.Write("Ответ: " + result);

int Input(string numbers)
{
    Console.Write($"{numbers}");
    return Convert.ToInt16(Console.ReadLine());
}
