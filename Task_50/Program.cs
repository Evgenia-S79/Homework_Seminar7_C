// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetNumberFromConsole (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

void InputOutput(int[,] arr, int rows, int colums)
{
    if (rows < arr.GetLength(0) && colums < arr.GetLength(1))
    {
        Console.WriteLine(arr[rows, colums]);
    }
    else 
    {
        Console.WriteLine($"{rows}, {colums} -> элемента с таким индексом в массиве нет.");
    }
}

int rows = GetNumberFromConsole ("Введите индекс строки");
int colums = GetNumberFromConsole ("Введите индекс столбца");
int[,] array = new int[5,5];
FillArrayRandom(array);
PrintArray(array);
InputOutput(array, rows, colums);