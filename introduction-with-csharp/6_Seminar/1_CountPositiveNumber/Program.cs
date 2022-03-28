using System.Text;
/// <summary>
/// Возвращает созданный пользователем массив.
/// </summary>
IReadOnlyCollection<int> InputIntArray(int M)
{
    Console.WriteLine($"Пожалуйста введите {M} чисел через Enter:");
    var array = new List<int>();

    for (int i = 0; i < M; i++)
    {
        var itemNew = int.Parse(Console.ReadLine());
        array.Add(itemNew);
    }

    return array;
}

/// <summary>
/// Возвразщает кол-во числе в массиве > 0.
/// </summary>
int CountPositiveNumbers(in IReadOnlyCollection<int> array)
    => array.Where(item => item > 0)
            .Count();

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

Console.Write("Сколько чисел собираетесь вводить?: ");
var M = int.Parse(Console.ReadLine());
var array = InputIntArray(M);
Console.WriteLine($"{GetStringArray(array)} -> {CountPositiveNumbers(array)}");