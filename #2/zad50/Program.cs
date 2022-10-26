// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}
void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SearchArray(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                Console.WriteLine($"{number} - такое число в массиве есть.");
                Console.WriteLine($"Смотри столбец номер {j + 1} и строку номер {i + 1}.");
                return;
            }
        }
    }
    Console.WriteLine($"{number} - такого числа в массиве нет");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] myArray = GetArray(row, columns, 0,10);
PrintArray(myArray);
Console.WriteLine();
SearchArray(myArray, number);
