
/// <summary>
/// Возводит число <paramref name="basisDegree"/> в степень <paramref name="indicatorDegree"/>
/// </summary>
/// <param name="basisDegree">Основание степени.</param>
/// <param name="indicatorDegree">Показатель степени.</param>
int Exponentiation(int basisDegree, int indicatorDegree)
{
    var res = 1;

    while (indicatorDegree > 0)
    {
        res *= basisDegree;
        indicatorDegree--;
    }

    return res;
}

Console.Write("Введите основание степени: ");
var basisDegree = int.Parse(Console.ReadLine());

Console.Write("Введите показатель степени: ");
var indicatorDegree = int.Parse(Console.ReadLine());

Console.WriteLine($"{basisDegree}, {indicatorDegree} -> " +
    $"{Exponentiation(basisDegree, indicatorDegree)} " +
    $"({basisDegree}^{indicatorDegree})");