
/// <summary>
/// Возвращает сумму цифр числа <paramref name="num" />
/// </summary>
int SumDigitsNumber(int num)
{
    var sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

Console.Write("Введите целое число: ");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} -> {SumDigitsNumber(num)}");