/// <summary>
/// Возвращает True если номер дня недели является выходным.
/// </summary>
bool IsWeekend(short numDayOfWeek) => 
            numDayOfWeek == 6 || // суббота
            numDayOfWeek == 7; // воскресенье

Console.Write("Введите номер дня недели: ");
var numDayOfWeek = short.Parse(Console.ReadLine());

if (IsWeekend(numDayOfWeek))
    Console.WriteLine($"{numDayOfWeek} -> да");
else
    Console.WriteLine($"{numDayOfWeek} -> нет");