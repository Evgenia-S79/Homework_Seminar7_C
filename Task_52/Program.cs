// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArrayRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,10);;
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,]arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double mid = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            mid += arr[i, j];
        }
        Console.Write($"{ mid / arr.GetLength(0)} ");
    }
}

int[,] array = new int[4,4];
FillArrayRandom(array);
PrintArray(array);
ArithmeticMean(array);