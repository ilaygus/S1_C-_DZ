// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!); 
int index = 1;

while (index <= x) 
{
if (index % 2 == 0) 
{
Console.Write($"{index} "); 
}
index++; 
}