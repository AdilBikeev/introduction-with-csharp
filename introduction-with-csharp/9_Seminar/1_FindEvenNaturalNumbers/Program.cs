
using System.Text;

/// <summary>
/// Возвращает четные натуральные числа в промежутке [m, n]
/// </summary>
IReadOnlyCollection<int> FindEvenNaturalNumbers(int m, int n)
{
    if (m <= 0) // m is not natural number
        m = 2;
    else if (m % 2 == 1) // m is odd number
        m++;

    var evenNaturalNumbers = new List<int>();
    for (;  m <= n; m += 2)
    {
        evenNaturalNumbers.Add(m);
    }

    return evenNaturalNumbers;
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

var evenNaturalNumbers = FindEvenNaturalNumbers(m, n);
Console.WriteLine($"M={m}; N={n} ->  {GetStringArray(evenNaturalNumbers)}");