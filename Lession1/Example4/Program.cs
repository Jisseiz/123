Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

for (int i = 2; i <= numberA; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");
