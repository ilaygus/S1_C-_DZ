// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GetNatural(int n)
{
    if (n == 1) 
    {
        return $"{1}";
    }
    return $"{n}, " + GetNatural(n - 1);
}

Console.Clear();
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"N = {n} -> \"{GetNatural(n)}\"");