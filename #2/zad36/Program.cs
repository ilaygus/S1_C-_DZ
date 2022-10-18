// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumNov(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Clear();
int[] ArrayResult = GetArray(5, -99, 99);
int sum = SumNov(ArrayResult);

Console.WriteLine($"В массиве {String.Join(", ", ArrayResult)} сумма элементов на нечетных позициях индексов = {sum}");
