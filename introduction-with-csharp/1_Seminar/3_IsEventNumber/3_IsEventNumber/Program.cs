/// <summary>
/// Првоеряет является ли входное число четным.
/// </summary>
/// <param name="num">Входное целое число.</param>
/// <return>True - Если число четное и False в ином случаи.</return>
bool IsEvenNumber(int num) => num % 2 == 0;

Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine());
var result = IsEvenNumber(num) ? "да" : "нет";

Console.WriteLine($"{num} -> {result}");