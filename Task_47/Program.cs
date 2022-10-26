// Задайте двумерный массив размером mxn, заполненный случайными целыми числами.

int GetNumberFromConsole (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}
double[,] InitializateArray(int m, int n)
{
    return new double[m,n];
}

int m = GetNumberFromConsole ("Введите количество столбцов");
int n = GetNumberFromConsole ("Введите количество строк");
double[,] array = InitializateArray(m, n);
FillArrayRandom(array);
PrintArray(array);