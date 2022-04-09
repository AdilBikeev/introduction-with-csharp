/// <summary>
/// Вычисляет функцию Аккермана.
/// </summary>
int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}


Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());

Console.WriteLine($"M={m}; N={n} -> A(m,n)={AckermanFunction(m, n)}");