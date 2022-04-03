using System.Text;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Возвращает трехмерную матрицу случайных элементов.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<IReadOnlyCollection<int>>> GenerateRandomIntThreeDimMatrxi(
    int rowsCount = 3, 
    int columnCount = 3, 
    int depth = 3)
{
    var matrixHashElements = new HashSet<int>();
    var matrix = new List<IReadOnlyCollection<IReadOnlyCollection<int>>>();
    for (int i = 0; i < depth; i++)
    {
        matrix.Add(GenerateRandomIntMatrix(rowsCount, columnCount, matrixHashElements));
    }

    return matrix;
}

/// <summary>
/// Возвращает матрицу размерности MxN.
/// </summary>
IReadOnlyCollection<IReadOnlyCollection<int>> GenerateRandomIntMatrix(int m = 4, int n = 4, HashSet<int> hashSet = default!)
{
    var matrix = new List<IReadOnlyCollection<int>>();
    for (int i = 0; i < m; i++)
    {
        var row = GenerateRandomIntArray(n, hashSet);
        matrix.Add(row);
    }

    return matrix;
}

/// <summary>
/// Возвращает массив вещественных чисел.
/// </summary>
IReadOnlyCollection<int> GenerateRandomIntArray(int n, HashSet<int> hashSet = default!)
{
    var array = new List<int>();
    var rnd = new Random();

    while (n > 0)
    {
        var itemNew = 10;
        while (!hashSet.Add(itemNew))
        {
            itemNew = rnd.Next(10, 99);
        }

        array.Add(itemNew);
        n--;
    }

    return array;
}

/// <summary>
/// Выводит построчно элементы трехмерной матрицы <paramref name="matrix"/>.
/// </summary>
void PrintThreeDimMatrix(in IReadOnlyCollection<IReadOnlyCollection<IReadOnlyCollection<int>>> matrixThreeDim)
{
    var matrixOutput = new StringBuilder();
    var depth = matrixThreeDim.Count;
    var rowsCount = matrixThreeDim.First().Count;
    var columnsCount = matrixThreeDim.First().First().Count;


    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rowsCount; j++)
        {
            for (int k = 0; k < columnsCount; k++)
            {
                var item = matrixThreeDim.ElementAt(i)
                    .ElementAt(j)
                    .ElementAt(k);

                Console.WriteLine($"a[{i},{j},{k}]={item}");
            }
        }
    }
}

var matrixA = GenerateRandomIntThreeDimMatrxi();
Console.WriteLine("Трехмерный массив:");
PrintThreeDimMatrix(matrixA);
