//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите значение N");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(numberN));

string PrintNumbers(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    else
    {
        return n.ToString() + ", " + PrintNumbers(n - 1);
    }
}
