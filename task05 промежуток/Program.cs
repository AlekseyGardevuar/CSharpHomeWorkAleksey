﻿/*
5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

System.Console.WriteLine("Введите число: ");
int chislo = int.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Целые числа в диапазоне от {-chislo} до {chislo} ");

if (chislo < 0)
    chislo = -chislo;

for (int i = -chislo; i <= chislo; i++)
{ 
    System.Console.Write(i); 
    if(i < chislo)
        System.Console.Write(", ");
}