/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] GetArray(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
    return array;
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

void SredAref(int[,] arr)
{
    double sredAref = 0;
    double summ = 0;
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    Console.ResetColor();
    for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                summ += arr[i, j];
            }
            sredAref = summ / arr.GetLength(0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(Math.Round(sredAref, 2) + "\t");
            summ = 0;
            sredAref = 0;
        }
        Console.ResetColor();
}



int[,] arrayRnd = GetArray(4, 4);
PrintMatrix(arrayRnd);
SredAref(arrayRnd);

