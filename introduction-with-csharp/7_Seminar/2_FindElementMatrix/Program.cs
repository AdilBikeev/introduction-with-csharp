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
/// Возвращает либо значение самого элемента матрицы, либо сообщение об ошибке.
/// </summary>
string FindElementMatrix(int rowIndex, int columnIdenx, in IReadOnlyCollection<IReadOnlyCollection<int>> matrix)
{
    if (rowIndex > matrix.Count ||
        columnIdenx > matrix.First().Count)
        return "такого числа в массиве нет";

    return matrix.ElementAt(rowIndex - 1)
                 .ElementAt(columnIdenx - 1)
                 .ToString();
}

var matrix = GenerateRandomIntMatrix();
var matrixString = GetStringMatrix(matrix);
Console.WriteLine("Задан массив:");
Console.WriteLine(matrixString);

Console.Write("Введите номер строки искомого элемента(нумерация с 1):");
var rowIndex = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента(нумерация с 1):");
var columnIndex = int.Parse(Console.ReadLine());

Console.WriteLine($"{rowIndex} {columnIndex} -> {FindElementMatrix(rowIndex, columnIndex, matrix)}");

