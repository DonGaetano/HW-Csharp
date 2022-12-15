//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
//Размер массива, минимальное значение и максимальное значение вводим через консоль 
 
Console.WriteLine("Введите размер массива"); 
int number1 = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите минимальное значение"); 
int number2 = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите максимальное значение"); 
int number3 = int.Parse(Console.ReadLine()!); 
 
int[] firstArray = GenerateArray(number1, number2, number3); 
PrintArray(firstArray); 
 
Console.WriteLine(CalculateSum(firstArray)); 
 
int[] GenerateArray(int size, int min, int max) 
{ 
    int[] array = new int[size]; 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = new Random().Next(min, max + 1); 
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
 
int CalculateSum(int[] array) 
{ 
    int sum = 0; 
    for (int i = 1; i < array.Length; i = i + 2) 
    { 
        sum = sum + array[i]; 
    } 
    return sum; 
}
