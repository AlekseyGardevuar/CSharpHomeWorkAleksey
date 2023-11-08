/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

Console.Clear();

double[,] GetArray(int rows, int colom)
{
    double[,] array = new double[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(Math.Round(arr[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

System.Console.Write("Введите количество cтрок в таблице: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в таблице: ");
int colom = Convert.ToInt32(Console.ReadLine());

double[,] arrayVeshestv = GetArray(rows, colom);
PrintMatrix(arrayVeshestv);


