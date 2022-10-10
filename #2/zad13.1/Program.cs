// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (Math.Abs(number) < 100)
{
Console.Write("третьей цифры нет");
}
else
{
if (Math.Abs(number) > 999)
while (Math.Abs(number) > 999)
{
number = number / 10;
}
Console.Write(Math.Abs(number) % 10);
}
