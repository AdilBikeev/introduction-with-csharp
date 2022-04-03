using System.Text;

/// <summary>
/// Генерирует прямоугольную матрицу NxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> GenerateRectangularIntMatrix(int N = 4)
    => GenerateRandomIntMatrix(N, N);

/// <summary>
/// Возвращает матрицу размерности MxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> GenerateRandomIntMatrix(int m = 4, int n = 4)
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
/// Возвращает массив вещественных чисел.
/// </summary>
IReadOnlyCollection<int> GenerateRandomIntArray(int n)
{
    var array = new List<int>();
    var rnd = new Random();

    while (n > 0)
    {
        var itemNew = rnd.Next(1, 10);
        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Возвращает строковое представление матриы <paramref name="matrix"/>.
/// </summary>
string GetStringMatrix(in IReadOnlyCollection<IReadOnlyCollection<int>> matrix)
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
string GetStringArray(in IReadOnlyCollection<int> array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join("\t", array);
}

/// <summary>
/// Возвращает строку матрицы с минимальной суммой элементов.
/// </summary>
IReadOnlyCollection<int> FindRowWithMinSumMatrixElements(in IReadOnlyCollection<IReadOnlyCollection<int>> matrix)
{
    var minSum = matrix.Min(row => row.Sum());
    return matrix.First(row => row.Sum() == minSum); 
}

var matrix = GenerateRectangularIntMatrix();
Console.WriteLine("Задан массив:");
Console.WriteLine(GetStringMatrix(matrix));

var minSumRow = FindRowWithMinSumMatrixElements(matrix);
Console.WriteLine("Строка с минимальной суммой элементов:");
Console.WriteLine(GetStringArray(minSumRow));