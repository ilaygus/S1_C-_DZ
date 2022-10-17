// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] Get(string Array)
{
    Array = Array + ",";
    int count = 0;
    int j = 0;
    int length = Array.Length;
    for (int i = 0; i < length; i++)
    {
        if (Array[i] == ',') count++;
    }
    int[] NewArray = new int[count];

    for (int i = 0; i < Array.Length; i++)
    {
        string TempArray = "";

        while (Array[i] != ',' && i < Array.Length)
        {
            TempArray += Array[i];
            i++;
        }
        NewArray[j] = Convert.ToInt32(TempArray);
        j++;
    }
    return NewArray;
}

void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
}


Console.Clear();

Console.Write("Введите числа через запятую, : ");
string array = Console.ReadLine()!;


int[] NewArray = Get(array);
PrintArray(NewArray);
