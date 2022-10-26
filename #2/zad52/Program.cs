//Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

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

void SearchArifmetic(int[,] array)
{
    double sum = 0;
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round(sum / array.GetLength(0), 2);
}
Console.WriteLine($"[{String.Join("; ", result)}]");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] myArray = GetArray(row, columns, 0,10);
PrintArray(myArray); 
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
SearchArifmetic(myArray);
