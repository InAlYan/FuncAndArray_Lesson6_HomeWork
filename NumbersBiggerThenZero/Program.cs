// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CountPositiveNumbers(int countNumbers)
{
    int positiveCount = 0;
    for (int i = 0; i < countNumbers; i++) 
        if (InputNumber($"Введите число {i}: ") > 0) positiveCount++;
    return positiveCount;
}

int num = InputNumber("Количество чисел для ввода пользователем с клавиатуры: ");
Console.WriteLine($"Количество чисел больше нуля: {CountPositiveNumbers(num)}");