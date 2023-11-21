/*
Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
*/


Console.Clear();

int[,] GetRnd(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[{i}] \t");
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        System.Console.Write(" " + arr[i, j] + "\t");
        }
        Console.ResetColor();
        System.Console.WriteLine();
    }
    //Console.ResetColor();
}

int[,] ArrayMtrix = GetRnd(6,6);
PrintMatrix(ArrayMtrix);