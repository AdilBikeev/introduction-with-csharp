
using System.Text;

/// <summary>
/// Возвращает сумму натуральных чисел в промежутке [m, n]
/// </summary>
int SumNaturalNumbers(int m, int n)
{
    if (m <= 0) // m is not natural number
        m = 1;

    var sum = 0;
    for (;  m <= n; m++)
    {
        sum += m;
    }

    return sum;
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(in IReadOnlyCollection<int> array, string delimeter = ", ")
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join(delimeter, array).Trim();
}

Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());

var sum = SumNaturalNumbers(m, n);
Console.WriteLine($"M={m}; N={n} -> {sum}");