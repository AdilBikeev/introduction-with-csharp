using System.Text;

/// <summary>
/// Возвращает матрицу размерности MxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> GenerateRandomIntMatrix(int m = 3, int n = 4)
{
    var matrix = new List<IReadOnlyCollection<int>>();
    for (int i = 0; i < m; i++)
    {
        var row = GenerateRandomIntArray(n);
        matrix.Add(row);
    }

    return matrix;
}

/// <summary>
/// Возвращает массив целых чисел.
/// </summary>
IReadOnlyCollection<int> GenerateRandomIntArray(int n)
{
    var array = new List<int>();
    var rnd = new Random();

    while (n > 0)
    {
        var itemNew = rnd.Next(0, 10);
        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Возвращает строковое представление матриы <paramref name="matrix"/>.
/// </summary>
string GetStringMatrix<T>(in IReadOnlyCollection<IReadOnlyCollection<T>> matrix)
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
string GetStringArray<T>(in IReadOnlyCollection<T> array, string delimiter = "\t")
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join(delimiter, array);
}

/// <summary>
/// Возвращает список с средними значениями его столбцов.
/// </summary>
IReadOnlyCollection<double> GetAvgColumnValuesMatrix(in IReadOnlyCollection<IReadOnlyCollection<int>> matrix)
{
    var avgColumnValues = new List<double>();
    var columnsCount = matrix.First().Count;

    // Пробегаемся по каждому столбцу
    for (int columntIndex = 0; columntIndex < columnsCount; columntIndex++)
    {
        double sum = 0;

        // Пробегаемся по каждой строке столбца
        for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
        {
            sum += matrix.ElementAt(rowIndex)
                         .ElementAt(columntIndex);
        }

        avgColumnValues.Add(
            Math.Round(sum / matrix.Count, 2)
       );
    }

    return avgColumnValues;
}

var matrix = GenerateRandomIntMatrix();
var matrixString = GetStringMatrix(matrix);
Console.WriteLine("Задан массив:");
Console.WriteLine(matrixString);

var avgColumnValues = GetAvgColumnValuesMatrix(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {GetStringArray(avgColumnValues, "; ")}");