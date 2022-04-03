using System.Text;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Генерирует прямоугольную матрицу NxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> GenerateRectangularIntMatrix(int N = 2)
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
/// Возвращает результат произведения двух матриц.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> ProductMatrices(
    in IReadOnlyCollection<IReadOnlyCollection<int>> matrixA, 
    in IReadOnlyCollection<IReadOnlyCollection<int>> matrixB)
{
    var rowsCount = matrixB.Count;
    var columnsCount = matrixB.First().Count;
    var res = new List<List<int>>(rowsCount);
    
    for (int i = 0; i < rowsCount; i++)
    {
        res.Add(new List<int>(columnsCount));
        for (int j = 0; j < columnsCount; j++)
        {
            res[i].Add(0);
            for (int k = 0; k < rowsCount; k++)
            {
                var itemA = matrixA.ElementAt(i)
                                   .ElementAt(k);
                
                var itemB = matrixB.ElementAt(k)
                                   .ElementAt(j);
                
                res[i][j] += itemA * itemB;
            }
        }
    }

    return res;
}

var matrixA = GenerateRectangularIntMatrix();
Console.WriteLine("Задан массив A:");
Console.WriteLine(GetStringMatrix(matrixA));

Console.WriteLine();

var matrixB = GenerateRectangularIntMatrix();
Console.WriteLine("Задан массив B:");
Console.WriteLine(GetStringMatrix(matrixB));

Console.WriteLine();

var matrixC = ProductMatrices(matrixA, matrixB);

Console.WriteLine("Результат произведения матриц:");
Console.WriteLine(GetStringMatrix(matrixC));