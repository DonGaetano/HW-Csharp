// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
 
Console.WriteLine("Введите 2 числа"); 
 
string num1 = Console.ReadLine()!; 
string num2 = Console.ReadLine()!; 
 
int parsed1 = int.Parse(num1); 
int parsed2 = int.Parse(num2); 
 
if (parsed1 == parsed2) 
{ 
    Console.WriteLine("Они равны"); 
} 
else 
{ 
    if (parsed1 > parsed2) 
    { 
        Console.WriteLine(parsed1 + " большее, а " + parsed2 + " - меньшее"); 
    } 
    else 
    { 
        Console.WriteLine(parsed2 + " большее, а " + parsed1 + " - меньшее"); 
 
    } 
}
