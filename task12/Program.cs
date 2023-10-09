/*12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.Write("Задай первое число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задай первое число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if(numberTwo % number == 0)
{
    System.Console.WriteLine($"Число {number} кратное числу {numberTwo}!");
}
else
{
    int result = numberTwo % number;
    System.Console.WriteLine($"Остаток от деления: {result}");
}