Console.Write("Введите число для 'a': ");
var a = int.Parse(Console.ReadLine());

Console.Write("Введите число для 'b': ");
var b = int.Parse(Console.ReadLine());

Console.WriteLine($"a = {a}; b = {b} -> max = {Math.Max(a, b)}, min = {Math.Min(a, b)}");