// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum(int m, int n)
{
    if (m == n) 
    {
        return n;
    }
    if (m > n) 
    {
        return m + GetSum(m - 1, n);
    }
    return m + GetSum(m + 1, n);
}

Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"M = {m}; N = {n} -> {GetSum(m, n)}");