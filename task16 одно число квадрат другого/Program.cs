/*16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

System.Console.Write("Задай первое число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задай первое число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int kvadrat1 = number * number;
int kvadrat2 = numberTwo * numberTwo;
if(numberTwo % kvadrat1 == 0 || number % kvadrat2 == 0)
{
    System.Console.WriteLine("Условие задачи выполняется!");
}
else
{
    System.Console.WriteLine("Условие задачи не выполняется!");
}