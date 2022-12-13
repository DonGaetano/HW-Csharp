// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Ограничения:
//- Должна быть отдельная функция, которая возвращает результат суммы цифр
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);

int SumFromFunction = SumDigits(number1);
Console.WriteLine(SumFromFunction);

int SumDigits(int firstNumber)
{
    int sum = firstNumber % 10;
    while (firstNumber > 9)
    {
        firstNumber = firstNumber / 10;
        sum = sum + firstNumber % 10;
    }
    return sum;
}
