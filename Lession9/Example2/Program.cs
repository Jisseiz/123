Console.Write("N: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("M: ");
int m = Convert.ToInt16(Console.ReadLine());
CalculateSumm(m, n);

int CalculateSumm(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
        Console.WriteLine(CalculateSumm(n, m));
    }
    return (end + start) * (end - start + 1) / 2;
}




