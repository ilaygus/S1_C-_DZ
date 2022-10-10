// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
if ((number < 1) || (number > 7))
{
Console.WriteLine ("ошибка");
}
else
{
if ((number == 6) || (number == 7))
Console.WriteLine ("Да");

else
{
Console.WriteLine ("Нет");
}
}
