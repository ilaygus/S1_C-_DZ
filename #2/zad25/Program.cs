// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


void Pow(int a, int b)
{
    int Get = 1;
    int z = 1;  
    if (b < 0) z = -1;

    for (int i = 0; i != b * z; i++)
{
        Get = Get * a;
}
     Console.WriteLine($"число {a} в степени {b} = {Get}");
}

Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Pow(a, b);