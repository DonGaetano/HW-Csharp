// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

int number1 = int.Parse(Console.ReadLine()!);

if (number1 >= 100 && number1 <= 999)
{
    int number2 = number1 / 10;
    int number3 = number2 % 10;
    Console.WriteLine($"Вторая цифра - {number3}");

}
else
{
    Console.WriteLine("Это число не трехзначное, идиот!");

}
