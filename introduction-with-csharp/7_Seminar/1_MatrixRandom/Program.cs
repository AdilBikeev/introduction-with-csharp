using System.Text;

/// <summary>
/// Возвращает матрицу размерности MxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<float>> GenerateRandomFloatMatrix(int m, int n)
{
    var matrix = new List<IReadOnlyCollection<float>>();
    for (int i = 0; i < m; i++)
    {
        var row = GenerateRandomFloatArray(n);
        matrix.Add(row);
    }

    return matrix;
}

/// <summary>
/// Возвращает массив вещественных чисел.
/// </summary>
IReadOnlyCollection<float> GenerateRandomFloatArray(int n)
{
    var array = new List<float>();
    var rnd = new Random();

    while (n > 0)
    {
        var itemNew = (float)Math.Round(rnd.NextSingle(), 2);
        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Возвращает строковое представление матриы <paramref name="matrix"/>.
/// </summary>
string GetStringMatrix(in IReadOnlyCollection<IReadOnlyCollection<float>> matrix)
{
    var matrixOutput = new StringBuilder();

    foreach (var row in matrix)
    {
        matrixOutput.Append(GetStringArray(row))
                    .Append("\n");
    }

    return string.Join(String.Empty, matrixOutput);
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(in IReadOnlyCollection<float> array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }
    
    return string.Join("\t", array);
}

Console.Write("Введите кол-во строк в матрице m: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице n: ");
var n = int.Parse(Console.ReadLine());

var matrix = GenerateRandomFloatMatrix(m, n);
var matrixString = GetStringMatrix(matrix);

Console.WriteLine($"m = {m}, n = {n}.");
Console.WriteLine(matrixString);
