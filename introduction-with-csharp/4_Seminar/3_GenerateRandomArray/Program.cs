using System.Text;

/// <summary>
/// Возвращает массив целых чисел.
/// </summary>
IReadOnlyCollection<int> GenerateRandomIntArray(int n = 8)
{
    var array = new List<int>();
    var rnd = new Random();

    while (n > 0)
    {
        int itemNew = rnd.Next();
        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Выводит в консоль содержимое массива <paramref name="array"/>.
/// </summary>
void PrintIntArray(in IReadOnlyCollection<int> array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item)
                 .Append(" ");
    }

    // Проще конечно так.
    //Console.WriteLine(string.Join(",", array));
    Console.WriteLine(arrOutput.ToString()
                               .Trim());
}

var arrayRandom = GenerateRandomIntArray();
Console.Write("Сгенерированный массив случайных чисел: ");
PrintIntArray(arrayRandom);