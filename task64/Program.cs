/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

void DigitDiapas (int start, int end = 1)
{
    if(end>start)
    {
        return;
    }
    else
    {
        System.Console.Write(start + " ");
        DigitDiapas(start - 1, end);
    }
}

DigitDiapas(8);