﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Get(int a)
{
    int sum = 0;
    while (a != 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    Console.Write($"{sum} ");
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Get(n);
