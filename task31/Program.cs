/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
равна 29, сумма отрицательных равна -20.
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(200);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

void SumArray(int[] arr)
{
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) summPos = summPos + arr[i];
        else summNeg = summNeg + arr[i];
    }
    System.Console.WriteLine("Сумма положительных чисел в массиве равна:" + summPos);
    System.Console.Write("Сумма отрицательных чисел в массиве равна:" + summNeg);
}

int[] userArray = GetRnd(12);
PrintArray(userArray);
System.Console.WriteLine();
SumArray(userArray);