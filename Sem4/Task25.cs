// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//Ограничения:
//- Нельзя использовать класс Math
//- Должна быть отдельная функция Power, которая возвращает результат
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите два числа");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

int MultFromFunction = Power(number1, number2);
Console.WriteLine(MultFromFunction);

int Power(int firstNumber, int secondNumber)
{
    int mult = firstNumber;
    for (int i = 1; i < secondNumber; i++)
    {
        mult = mult * firstNumber;
    }
    return mult;
}
