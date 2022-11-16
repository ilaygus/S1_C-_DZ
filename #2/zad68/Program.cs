// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int GetAkker(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m > 0 && n == 0) 
    {
        return GetAkker(m - 1, 1);
    }
    if (m > 0 && n > 0) 
    {
        return GetAkker(m - 1, GetAkker(m, n - 1));
    }
    return GetAkker(m, n);
}

Console.Clear();
Console.Write("Задайте значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {GetAkker(m, n)}");