/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(System.Console.ReadLine());

if (number > 999 || number < 100)
    System.Console.WriteLine("Число не трёхзначное");


System.Console.WriteLine("Последняя цифра: ");
System.Console.WriteLine(number % 10);