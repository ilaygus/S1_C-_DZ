// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
int max;

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
max = number1;
}
else
{
max = number2;
}
if (number3 > max)
{
max = number3;
}
Console.Write($"максимальное число {max} ");