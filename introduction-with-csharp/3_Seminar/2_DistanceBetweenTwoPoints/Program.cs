const string DelimeterDefault = " ";

/// <summary>
/// Возвращает расстояние 2-я между по их координатам.
/// </summary>
/// <param name="pointA">Список с размером 3 с координатами точки А.</param>
/// <param name="pointB">Список с размером 3 с координатами точки B.</param>
float GetDistanceBetweenTwoPoints(
    IReadOnlyList<int> pointA,
    IReadOnlyList<int> pointB
    )
{
    return (float)Math.Sqrt(
           Math.Pow(pointA[0] - pointB[0], 2) +
           Math.Pow(pointA[1] - pointB[1], 2) +
           Math.Pow(pointA[2] - pointB[2], 2)
        );
}

/// <summary>
/// Возвращает данные для точки из вводимых 
/// пользователем данных с клавиатуры.
/// </summary>
/// <param name="pointName">Наименование точки.</param>
IReadOnlyList<int> GetPointData(string pointName)
{
    Console.Write($"Введите значения для точки '{pointName}' через пробел: ");

    return Console.ReadLine()
        .Split(DelimeterDefault)
        .Select(num => int.Parse(num))
        .ToList();
}

/// <summary>
/// Отображает координаты точки.
/// </summary
/// <param name="point">Список с размером 3 с координатами точки.</param>
/// <param name="pointName">Наименование точки.</param>
void ShowPointData(IReadOnlyList<int> point, string pointName)
    => Console.Write("{0}({1}, {2}, {3})", pointName, point[0], point[1], point[2]);

/// <summary>
/// Отображает результат работы программы.
/// </summary>
/// <param name="pointA">Список с размером 3 с координатами точки А.</param>
/// <param name="pointB">Список с размером 3 с координатами точки B.</param>
/// <param name="distance">Расстояние между 2-мя точками.</param>
void ShowResult(
    IReadOnlyList<int> pointA,
    IReadOnlyList<int> pointB,
    float distance)
{
    ShowPointData(pointA, "A");
    Console.Write(";");
    ShowPointData(pointB, "B");
    Console.Write(", -> {0:0.00}", distance);
}

var pointA = GetPointData("A");
var pointB = GetPointData("B");

var distance = GetDistanceBetweenTwoPoints(pointA, pointB);

ShowResult(pointA, pointB, distance);

