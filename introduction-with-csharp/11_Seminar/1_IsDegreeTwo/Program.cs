/// <summary>
/// Првоеряет является ли входное число степенью двойки.
/// </summary>
/// <param name="num">Входное целое число.</param>
bool IsDegreeTwo(int num) {
    return num == 0 ? false : (num & (num - 1)) == 0;
    // Если num - степень двойки, то оно имеет вид: 1000...000
    // Тогда предыдущее число до этой степень двойки в 2-ой СС имеет вид 1111...111
    // При побитовым умножением - получаем 0, если число действительно степень 2, и не 0, если не степень 2.
}

Console.Write("Введите число: ");
var N = int.Parse(Console.ReadLine());
var result = IsDegreeTwo(N) ? "Является степенью двойки" : 
                              "Не является степенью двойки";

Console.WriteLine($"N = {N} -> {result}");