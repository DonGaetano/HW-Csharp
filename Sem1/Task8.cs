// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.   
  
Console.WriteLine("Введите число N");  
  
string num1 = Console.ReadLine()!;  
int parsed1 = int.Parse(num1);  
  
for (int i = 1; i <= parsed1; i++)  
{  
    if (i % 2 == 0)  
    {  
        Console.WriteLine(i); 
    }  
}
