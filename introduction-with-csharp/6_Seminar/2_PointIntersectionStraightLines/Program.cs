/*
 Находим по формуле точку пересечения по оХ
1)
y=k1x + b1
y=k2x + b2

2) k1x + b1 = k2x + b2
3) x*(k1 - k2) = b2 - b1
4) x = (b2 - b1) / (k1 - k2)

 Находим по формуле точку пересечения по оY
1) y(x) = k1x + b1
2) x = (b2 - b1) / (k1 - k2)         (из решения выше)
=> y(x) = b1 + 
         k1 * 
         ((b2 - b1) / (k1 - k2))
            
 */

/// <summary>
/// Возвращает точку пересечения по оси ОХ двух прямых.
/// </summary>
float GetPointIntersectionOX(int k1, int b1, int k2, int b2)
    => (float)(b2 - b1) / 
       (k1 - k2);

/// <summary>
/// Возвращает точку пересечения по оси ОY двух прямых по известной точке пересечения по оси ОХ.
/// </summary>
float GetPointIntersectionOY(int k, int b, float x)
    => b + k * x;

Console.Write("Введите b1:");
var b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1:");
var k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2:");
var b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2:");
var k2 = int.Parse(Console.ReadLine());

var pointIntersectionOX = GetPointIntersectionOX(k1, b1, k2, b2);
var pointIntersectionOY = GetPointIntersectionOY(k1, b1, pointIntersectionOX);
Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({pointIntersectionOX}; {pointIntersectionOY})");

