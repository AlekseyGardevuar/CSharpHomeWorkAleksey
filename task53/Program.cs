/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
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

void ArraySwapRows(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
    }

    for (int i = 0; i < temp.Length; i++)
    {
        arr[arr.GetLength(0) - 1, i] = temp[i];
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("\t" + "\t" + "\t" + "\t"+ "\t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

int[,] RandomArray = GetRnd(4, 4);

PrintMatrix(RandomArray);

ArraySwapRows(RandomArray);

System.Console.WriteLine();
PrintMatrix(RandomArray);