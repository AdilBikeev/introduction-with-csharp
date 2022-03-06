/// <summary>
/// Проверяет является ли входное число палиндром.
/// </summary>
/// <param name="num">5-ти значное число.</param>
bool IsPalindrome(int num)
{
    var currNum = num;
    var digits = new List<int>();

    // Формируем массив из цифр исходного числа 
    // записанного в обратном порядке.
    while (currNum != 0)
    {
        digits.Add(currNum % 10);
        currNum /= 10;
    }

    var countDigits = digits.Count();

    // Если число явл. полиндромом - то дойдя до середины будет тому аргументом
    for (int i = 0; i < countDigits / 2; i++)
    {
        // Проверяем крайние цифры числа (слева и справа)
        // с каждой итерацией передвигая указатели к центру числа.
        // Если хотяб в 1-ой позиции будет отличие - число не явл. палиндромом по определению  
        if (digits[i] != digits[countDigits - i - 1])
            return false;
    }

    return true;
}


Console.Write("Введите 5-ти значное число: ");
var num = int.Parse(Console.ReadLine());

var result = IsPalindrome(num) ? "да" : "нет";
Console.WriteLine($"{num} -> {result}");