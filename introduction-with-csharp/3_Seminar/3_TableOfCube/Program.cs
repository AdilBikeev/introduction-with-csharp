
/// <summary>
/// Возвращает список кубов чисел от 1 до N. 
/// </summary>
IReadOnlyList<int> GetCubesN(int N)
{
    var cubes = new List<int>(N) { 1 };
    for (int i = 2; i <= N; i++)
        cubes.Add(
            (int)Math.Pow(i, 3)
        );

    return cubes;
}

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine());
var cubes = GetCubesN(N);

Console.WriteLine($"{N} -> {string.Join(", ", cubes)}");