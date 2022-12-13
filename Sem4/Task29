//Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.

Console.WriteLine("Введите размер массива");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение");
int number3 = int.Parse(Console.ReadLine()!);


int[] firstArray = GenerateArray(number1, number2, number3);
PrintArray(firstArray);

int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
 
    return array;
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
