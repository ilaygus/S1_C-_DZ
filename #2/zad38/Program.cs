// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size, double maximum, double minimum)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maximum - minimum) + minimum;
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

double MaxMinResult(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    double result = max - min;
    return result;
}

Console.Clear();
double[] ArrayResult = GetArray(5, 10, 99);
double result = MaxMinResult(ArrayResult);
Console.WriteLine($"В массиве [{String.Join(", ", ArrayResult)}] разница между максимальным и минимальным элементов массива = {result:f2}");
