// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
 
Console.WriteLine("Введите 3 числа"); 
 
string num1 = Console.ReadLine()!; 
string num2 = Console.ReadLine()!; 
string num3 = Console.ReadLine()!; 
 
int parsed1 = int.Parse(num1); 
int parsed2 = int.Parse(num2); 
int parsed3 = int.Parse(num3); 
 
int max = parsed1; 
 
if (parsed2 > max) max = parsed2; 
if (parsed3 > max) max = parsed3; 
 
Console.WriteLine(max + " наибольшее");
