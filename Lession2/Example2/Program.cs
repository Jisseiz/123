Console.WriteLine("Введите трехзначное число.");
string input = Console.ReadLine();
if (input.Length > 2)
{
    Console.Write($"{input}->{input[2]}");
}
else Console.WriteLine("третьей цифры нет");
