// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = Math.Abs(number);
}

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
