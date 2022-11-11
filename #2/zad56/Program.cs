// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void MinSumRows(int[,] array)
{
    int tempSum;
    int minSum = 0;
    int result = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        minSum += array[0, column];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        tempSum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            tempSum += array[row, column];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            result = row;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, columns,0,10);

PrintArray(array);
MinSumRows(array);
Console.WriteLine();
