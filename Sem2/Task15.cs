// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7");

int number = int.Parse(Console.ReadLine()!);

if (number <= 7 && number > 0)
{
    if (number == 7 || number == 6)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это будний день");
    }
}
else
{
    Console.WriteLine("Ваша цифра не подходит");
}
