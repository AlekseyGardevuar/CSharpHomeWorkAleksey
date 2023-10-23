/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/

Console.Clear();

/*void Fib(int n)
{
    if(n == 0) System.Console.Write("0");
    if(n == 1) System.Console.Write("0 1 ");

    int first = 

    for (int i = 2; i <= n; i++)
    {
        System.Console.Write((i - 2) + (i - 1) + " "); 
    }
}*/

int[] FiboArray(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
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


System.Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] arrayFib = FiboArray(number);
PrintArray(arrayFib);

/*if(n == 1 || n == 0) System.Console.Write("0");

    if(n >= 2)
    {
        System.Console.Write("0 1 ");

        int first = 0;
        int second = 1;
        
        int third = first + second;

        int count = 3;

        while(count <= n)
        {
            third = first+second;
            first = second;
            second = third;
            count++;

            System.Console.Write(third + " ");
        }
    }
*/