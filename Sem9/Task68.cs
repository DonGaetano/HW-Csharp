//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите неотрицательное число M");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите неотрицательное число N");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(AckFunc(numberM, numberN));

int AckFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckFunc(m - 1, 1);
    }
    else
    {
        return AckFunc(m - 1, AckFunc(m, n - 1));
    }
}
