/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int SummDiapas (int start, int max)
{
    int summ = 0;
    for (int i = start; i <= max; i++)
    {
        summ = i + summ;
    }
    return summ;
}

int summ = SummDiapas(1, 15);
System.Console.WriteLine(summ);