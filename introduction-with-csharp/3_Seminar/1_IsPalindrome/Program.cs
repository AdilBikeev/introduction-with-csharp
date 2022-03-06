/// <summary>
/// Взодное число
/// </summary>
/// <param name="numStr">5-ти значное число в форме строки.</param>
bool IsPalindrome(string numStr)
{
    for (int i = 0, j = numStr.Length - 1; 
        i < j; 
        i++, j--
        )
    {
        if (numStr[i] != numStr[j])
            return false;
    }

    return true;
}


Console.Write("Введите 5-ти значное число: ");
var numStr = Console.ReadLine();

var result = IsPalindrome(numStr) ? "да" : "нет";
Console.WriteLine($"{numStr} -> {result}");