
Console.Write("N: ");
int N = Convert.ToInt16(Console.ReadLine());
Integers();




void Integers()
{
    for (int i = 1; i <= N; i++)
        Console.Write($" {i}");
    return;
    Integers();
}
