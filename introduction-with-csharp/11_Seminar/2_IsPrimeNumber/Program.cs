/// <summary>
/// Проверяет является ли входное число простым.
/// </summary>
/// <param name="num">Входное целое число.</param>
bool IsPrimeNumber(int num) {
    if (num < 2) return false; // принято считать 0 и 1 - НЕ простыми
    if (num == 2) return true; // делится только на 2 и 1 - простое
    if (num % 2 == 0) return false; // если число четное, то не простое
    for (int i = 3; i * i <= num; i += 2) { // пробегаемся по НЕ четным числам, т.к. все четные - НЕ простые, при этом проверяем до квадрата числа, т.к. дальше числа не будет делиться
        if (num % i == 0) return false;
    }
    return true;
}

Console.Write("Введите число: ");
var N = int.Parse(Console.ReadLine());
var result = IsPrimeNumber(N) ? "Это простое число" : 
                              "Это не простое число";

Console.WriteLine($"N = {N} -> {result}");