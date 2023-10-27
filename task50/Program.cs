/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/

Console.Clear();

int[,] GetArray(int rows, int colom)
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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

void PoiskElements(int[,] arr, int rows, int colomn)
{
    int iskomoe = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(rows == i && colomn == j)
            {
            iskomoe = arr[i, j];
            break;
            }
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{rows} и {colomn} -> {iskomoe}");
}

int rowsMassiva = 5;
int colomnMassiva = 5;

int[,] arrayDlyaPoiska = GetArray(rowsMassiva, colomnMassiva);
PrintMatrix(arrayDlyaPoiska);
System.Console.WriteLine();
System.Console.Write("Введите строку для поиска: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец для поиска: ");
int colomn = Convert.ToInt32(Console.ReadLine());
if(rows >= rowsMassiva || colomn >= colomnMassiva) 
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"{rows} и {colomn} -> Такого числа в массиве нет, адрес неверный!");
    }
    else
    {
        PoiskElements(arrayDlyaPoiska, rows, colomn);
    }
    
