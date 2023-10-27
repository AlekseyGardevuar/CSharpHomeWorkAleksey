/*
 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

Console.Clear();

int[,] GetRnd(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(arr[i, j] + " ");
        /*if (i < arr.GetLength(0) - 1 || j < arr.GetLength(1) - 1)
            System.Console.Write(", ");*/
        }
        System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.ResetColor();
}

int[,] ArrayMtrix = GetRnd(3,3);
PrintMatrix(ArrayMtrix);
