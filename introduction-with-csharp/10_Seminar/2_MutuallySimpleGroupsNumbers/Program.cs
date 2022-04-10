
using System.Text;

IReadOnlyCollection<IReadOnlyCollection<int>> GetMutuallySimpleGroupsNumbers(int n)
{
    var groups = new List<List<int>>();
    for (int num = 1; num <= n; num++)
    {
        // Флаг указывающий о том, что число добавлено в группу
        bool isAdd = false;

        // Пробегаем по всем существующим группам
        foreach (var group in groups)
        {
            if (IsBelongsGroup(group, num))
            {
                group.Add(num);
                isAdd = true;
                break;
            }
        }

        // Если число не принадлежит ни одной группе, то создаем новую группу
        if (!isAdd)
        {
            var groupNew = new List<int>();
            groupNew.Add(num);
            groups.Add(groupNew);
        }
    }

    return groups;
}

/// <summary>
/// Првоеряет принадлежит ли текущее число группе взаимно простых чисел.
/// </summary>
/// <param name="group">Группа вазимно простых чисел.</param>
/// <param name="number">Кандидат на попадание в группу.</param>
bool IsBelongsGroup(in IReadOnlyCollection<int> group, int number)
    => group.All(item => number % item  != 0);

/// <summary>
/// Возвращает строковое представление матриы <paramref name="matrix"/>.
/// </summary>
string GetStringMatrix(in IReadOnlyCollection<IReadOnlyCollection<int>> matrix)
{
    var matrixOutput = new StringBuilder();

    for (int i = 0; i < matrix.Count; i++)
    {
        var row = matrix.ElementAt(i);
        matrixOutput.Append($"Группа {i + 1}: ")
                    .Append(GetStringArray(row))
                    .Append("\n");
    }

    return string.Join(String.Empty, matrixOutput);
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(in IReadOnlyCollection<int> array, string delimeter = "\t")
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join(delimeter, array);
}

Console.Write("Введите число N (кол-во натуральных чисел): ");
var n = int.Parse(Console.ReadLine()); 

var groups = GetMutuallySimpleGroupsNumbers(n);
Console.WriteLine($"N={n}, M={groups.Count}");
Console.WriteLine(GetStringMatrix(groups));
