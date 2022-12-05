// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.

Console.WriteLine("Введите число");

string number = Console.ReadLine();

if (number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine($"Третья цифра: {number[2]}");
}
