// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.

Console.WriteLine("Введите число");

string number = Console.ReadLine();
int parsed1 = int.Parse(number);

if (parsed1 >= 100)
{
    Console.WriteLine($"Третья цифра: {number[2]}");
}
else if (parsed1 <= -100)
{
    Console.WriteLine($"Третья цифра: {number[3]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
