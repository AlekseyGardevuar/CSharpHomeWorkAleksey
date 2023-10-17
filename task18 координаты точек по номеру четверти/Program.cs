/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();
System.Console.Write("Задай номер четверти от 1 до 4: ");
int chetvert = int.Parse(Console.ReadLine());

if (chetvert == 1)
{
    System.Console.WriteLine("Возможные координатные точки: X до +∞ и Y до +∞");
}
if (chetvert == 2)
{
    System.Console.WriteLine("Возможные координатные точки: X до -∞ и Y до +∞");
}
if (chetvert == 3)
{
    System.Console.WriteLine("Возможные координатные точки: X до -∞ и Y до -∞");
}
if (chetvert == 4)
{
    System.Console.WriteLine("Возможные координатные точки: X до +∞ и Y до -∞");
}
if (chetvert < 1 || chetvert > 4)
{
    System.Console.WriteLine("Это не число обозначающее координатную четверть!");
}