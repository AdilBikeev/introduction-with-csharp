
/// <summary>
/// Пробует взять третью цифру из входного числа в виде строки.
/// </summary>
/// <param name="num">Входное число в виде строки.</param>
/// <param name="result">Для хранения результата парсинга третьей цифры.</param>
/// <return>Возващает True - если удалось распарсить.</return>
bool TryParseThirdDigit(string num, out int result)
{
    result = default;
    if (num.Length < 3)
        return false;

    result = int.Parse(
        num.ElementAt(2) // Получаем 3-ю цифру числа
           .ToString() // преобразуем в строку
    ); // парсим строку в число

    return true;
}

Console.Write("Введите число: ");
var num = Console.ReadLine();

if (TryParseThirdDigit(num, out int thirdDigit))
    Console.WriteLine($"{num} -> {thirdDigit}");
else
    Console.WriteLine($"{num} -> третьей цифры нет");