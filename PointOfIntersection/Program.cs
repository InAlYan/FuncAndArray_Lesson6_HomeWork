// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PointOfLinesIntersection(double k1, double  b1, double  k2, double  b2)
{
    // y = k1 * x + b1, y = k2 * x + b2
    // k1 * x + b1 = k2 * x + b2
    // k1 - k2 * x = b2 - b1
    // x = (b2 - b1) / (k1 - k2)
    string message;
    if (k1 == k2) message = "Прямые не пересекаются...";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        message = $"({x}; {y})";
    }
    Console.WriteLine(message);
}

double k1 = InputNumber("Введите число k1: ");
double b1 = InputNumber("Введите число b1: ");
double k2 = InputNumber("Введите число k2: ");
double b2 = InputNumber("Введите число b2: ");

PointOfLinesIntersection(k1, b1, k2, b2);