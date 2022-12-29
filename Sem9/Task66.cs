//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение M");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение N");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(numberM, numberN));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}
