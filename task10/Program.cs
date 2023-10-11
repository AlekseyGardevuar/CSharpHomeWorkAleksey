/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int result = number / 10 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ошиблись!");
}