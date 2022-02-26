Console.Write("Введите число для 'a': ");
var a = int.Parse(Console.ReadLine());

Console.Write("Введите число для 'b': ");
var b = int.Parse(Console.ReadLine());

Console.Write("Введите число для 'c': ");
var c = int.Parse(Console.ReadLine());

Console.WriteLine($"{a}, {b}, {c} -> {Math.Max(Math.Max(a, b), c)}");