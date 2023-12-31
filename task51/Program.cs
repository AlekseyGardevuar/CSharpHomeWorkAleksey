﻿/*
 Задайте двумерный массив. Найдите сумму элементов, 
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[{i}] \t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(" " + arr[ i, j] + "\t");
        Console.ResetColor();
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

int SummaDiag(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result+= arr[i, i];
    }
    return result;
}

int[,] ArrayMatrix = GetRnd(5,7);
PrintMatrix(ArrayMatrix);
int summ = SummaDiag(ArrayMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел в диагонали = {summ}");