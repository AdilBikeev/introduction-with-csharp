/// <summary>
/// Првоеряет является ли входное число четным.
/// </summary>
/// <param name="num">Входное целое число.</param>
/// <return>True - Если число четное и False в ином случаи.</return>
bool IsEvenNumber(int num) => num % 2 == 0;

/// <summary>
/// Возвращает все четные числа от 1 до N.
/// </summary>
IReadOnlyList<int> EvenNumbers(int N)
{
    var evenNums = new List<int>();
    for (int i = 2; i <= N; i += 2)
        evenNums.Add(i);

    return evenNums;
}

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine());


Console.WriteLine($"{N} -> {string.Join(", ", EvenNumbers(N))}");