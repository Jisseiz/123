Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;

Console.WriteLine($"Максимальное число = {max}");

int min = numberA;

if (numberB < min) min = numberB;

Console.WriteLine($"Минимальное число = {min}");