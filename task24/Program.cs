/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();
int Numbers1(int numb)
{
    int sum = 0;
    for (int i = 0; i <= numb; i++)
    {
        sum = sum + i;
    }
    return sum;
}

System.Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");