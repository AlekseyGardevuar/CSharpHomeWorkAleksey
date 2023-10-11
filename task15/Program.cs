/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

/*System.Console.WriteLine("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string Day = "Ожидание";
if (dayNumber == 1) Day = "Понедельник - не выходной!";
if (dayNumber == 2) Day = "Вторник - не выходной!";
if (dayNumber == 3) Day = "Среда - не выходной!";
if (dayNumber == 4) Day = "Четверг - не выходной!";
if (dayNumber == 5) Day = "Пятница - не выходной!";
if (dayNumber == 6) Day = "Суббота - это выходной!";
if (dayNumber == 7) Day = "Воскресенье - это выходной!";

Console.Write($"Сегодня: {Day}");
*/

System.Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день!");
}
else if (dayNumber == 7 || dayNumber == 6)
{
    System.Console.WriteLine("Ура, выходной!");
}
else
{
    System.Console.WriteLine("Это не день недели!");
}