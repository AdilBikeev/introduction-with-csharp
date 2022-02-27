/// <summary>
/// Возвращает 2-ух значное число состоящее из первой и последней цифры исходного числа.
/// </summary>
/// <param name="num">Трехзначное число.</param>
int RemoveSecondDigitNumber(int num) => (num / 100) * 10 + // Берем первую цифру числа и умножаем на 10
                                        (num % 10); // Берем последнюю цифру числа - результат складываем

/// <summary>
/// Возвращает случайное число в пределах от min до max.
/// </summary>
/// <param name="min">Минималньое случайное число.</param>
/// <param name="max">Максимальное случайное число.</param>
int GetRandomNumber(int min = 111, int max = 999)
{
    var random = new Random();
    return random.Next(min, max);
}

var num = GetRandomNumber();

Console.WriteLine($"{num} -> {RemoveSecondDigitNumber(num)}");