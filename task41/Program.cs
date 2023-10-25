/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите число под номером{i+1}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
    System.Console.Write("]");
    Console.ResetColor();
}

void SumArray(int[] arr)
{
    int countPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) countPos++;
    }
    System.Console.WriteLine("Количество положительных чисел в массиве:" + countPos);
}


System.Console.Write("Введите количество символов, которые вы хотите ввести: ");
int kolvo = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(kolvo);
PrintArray(userArray);
System.Console.WriteLine();
SumArray(userArray);

/*
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
*/