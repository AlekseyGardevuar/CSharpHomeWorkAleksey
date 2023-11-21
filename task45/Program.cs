/*
45. Напишите программу, которая будет создавать копию
 заданного одномерного массива с помощью поэлементного копирования.
*/

Console.Clear();

/*int[] GetRandArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.Write(" ");
}

System.Console.Write("Ввести размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArray);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("-> ");

int[] CopyArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
PrintArray(CopyArray(userArray));*/

int[] GetArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
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
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("]");
    Console.ResetColor();
}

int[] CopyArr(int size, int[] arr)
{
    int[] arrayCopy = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arrayCopy[i] = arr[i];
    }
    return arrayCopy;
}


System.Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Первое число, от которого рандомить цифры в массиве: ");
int startArr = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число, до которого надо рандомить цифры в массиве: ");
int endArr = Convert.ToInt32(Console.ReadLine());


int[] arrayUser = GetArray(sizeArr, startArr, endArr);
PrintArray(arrayUser);
System.Console.WriteLine();
int[] arrayCopy = CopyArr(sizeArr, arrayUser);
PrintArray(arrayCopy);