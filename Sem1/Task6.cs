// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 
 
Console.WriteLine("Введите число"); 
 
string num1 = Console.ReadLine()!; 
 
int parsed1 = int.Parse(num1); 
 
if (parsed1 % 2 == 0) 
{ 
    Console.WriteLine("Число четное"); 
} 
else 
{ 
    Console.WriteLine("Число нечетное"); 
}
