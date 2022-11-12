// Задача 62: Заполните спирально массив 4 на 4.

int[,] FillArray()
{
    int size = 4;
    int[,] newArray = new int[size, size];
    int row = 0;
    int column = 0;

    for (int temp = 1; temp <= size * size; temp++)
    {
        newArray[row, column] = temp;
        if (row <= column + 1 && row + column < size - 1) column++;
        else if (row < column && row + column >= size - 1) row++;
        else if (row >= column && row + column > size - 1) column--;
        else row--;
    }
    return newArray;
}

void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10) Console.Write($"0{inArray[i, j]}\t ");
            else Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Print2dArray(FillArray());