//Пользователь вводит число M, затем считываем с клавиаутеры M чисел. 
//Посчитайте, сколько чисел больше 0 ввел пользователь. 
  
Console.WriteLine("Введите количество чисел");  
int numberM = int.Parse(Console.ReadLine()!);  
 
int[] firstArray = CollectNumbers(numberM); 
 
PrintArray(firstArray); 
 
Console.WriteLine(CountPositive(firstArray)); 
 
 
int[] CollectNumbers(int size)  
{  
    int[] array = new int[size];  
    Console.WriteLine($"Начинайте ввод {size} чисел(а)"); 
    for (int i = 0; i < array.Length; i++)  
    {  
        array[i] = int.Parse(Console.ReadLine()!);  
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
 
int CountPositive(int[] array) 
{ 
    int countPos = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if(array[i]>0) 
        { 
            countPos++; 
        } 
    } 
    return countPos; 
}
