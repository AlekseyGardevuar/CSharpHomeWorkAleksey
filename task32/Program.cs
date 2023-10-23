/*
32. Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

void RevArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] * -1);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}

int[] ArrayRnd = GetRnd(6);
PrintArray(ArrayRnd);
System.Console.WriteLine();
RevArray(ArrayRnd);