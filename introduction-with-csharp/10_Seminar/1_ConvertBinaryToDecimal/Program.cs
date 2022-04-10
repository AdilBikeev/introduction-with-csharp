using System.Text;
/// <summary>
/// Возвращает конвертированные двоичные числа в десятичные.
/// </summary>
/// <param name="data"></param>
/// <param name="info"></param>
/// <returns></returns>
IReadOnlyCollection<int> ConvertAllBinaryTODecimal(
    IReadOnlyCollection<byte> data,
    IReadOnlyCollection<int> info)
{
    var dataCopy = data.ToList();
    var results = new List<int>();

    for (int i = 0; i < info.Count; i++)
    {
        var numberLengt = info.ElementAt(i);
        var binaryNumbers = new List<byte>(numberLengt);

        binaryNumbers.AddRange(
            dataCopy.Take(numberLengt)
                    .Reverse()
        );
        results.Add(
            ConvertBinaryToDecimal(binaryNumbers)
        );
        dataCopy.RemoveRange(0, numberLengt);
    }

    return results;
}

/// <summary>
/// Преобразует массив из цифр бинарного числа в 10-тичную СС.
/// </summary>
int ConvertBinaryToDecimal(IReadOnlyCollection<byte> binary)
{
    var result = 0;
    var power = 0;
    foreach (var item in binary)
    {
        result += item * (int)Math.Pow(2, power);
        power++;
    }
    return result;
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(in IReadOnlyCollection<int> array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join("\t", array);
}


var data = new byte[]  {0, 1, 1, 1, 1, 0, 0, 0, 1 };
var info = new int[] {2, 3, 3, 1 };

var decimalNumbers = ConvertAllBinaryTODecimal(data, info);
Console.WriteLine(GetStringArray(decimalNumbers));