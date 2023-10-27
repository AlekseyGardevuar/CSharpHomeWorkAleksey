/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
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
        }
        System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.ResetColor();
}

void EvenElementsKvadrat(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

int[,] ArrayMatrix = GetRnd(3,3);
PrintMatrix(ArrayMatrix);
EvenElementsKvadrat(ArrayMatrix);
System.Console.WriteLine();
PrintMatrix(ArrayMatrix);