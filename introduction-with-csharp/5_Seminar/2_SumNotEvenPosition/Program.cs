using System.Text;

/// <summary>
/// Возвращает массив целых чисел.
/// </summary>
IReadOnlyList<int> GenerateRandomIntArray(int n = 4, int numMin = 1, int numMax = 100)
{
    var array = new List<int>();
    var rnd = new Random();

    while (n > 0)
    {
        int itemNew = rnd.Next(numMin, numMax);
        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(in IReadOnlyCollection<int> array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item)
                 .Append(" ");
    }

    return string.Join(",", array);
}

/// <summary>
/// Возвращает сумму элементов массива, стоящих на нечётных позициях.
/// </summary>
int SumNotEvenPositionNumbers(in IReadOnlyList<int> numbers)
{
    var sum = 0;

    for (int i = 0; i < numbers.Count; i+=2)
    {
        sum += numbers[i];
    }

    return sum;
}

var arrayRandom = GenerateRandomIntArray();
var sumNotEvenPositionNumbers = SumNotEvenPositionNumbers(arrayRandom);
Console.WriteLine($"[{GetStringArray(arrayRandom)}] -> {sumNotEvenPositionNumbers}");