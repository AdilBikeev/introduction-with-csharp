/// <summary>
/// Возвращает 2-ую цифру трехзначного числа.
/// </summary>
/// <param name="num">Трехзначное число.</param>
int ParseSecondDigitNumber(int num) => (num / 10) // Убираем последнюю цифру у числа num -> останутся первые 2 цифры
                                       % 10; // Берем последнюю цифру, т.к. она и будет 2-ой

Console.Write("Введите 3-ех значное число: ");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} -> {ParseSecondDigitNumber(num)}");