/*
3. Напишите программу, которая будет выдавать название дня недели по заданному 
номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string Day = "Ожидание";
if (dayNumber == 1) Day = "Понедельник";
if (dayNumber == 2) Day = "Вторник";
if (dayNumber == 3) Day = "Среда";
if (dayNumber == 4) Day = "Четверг";
if (dayNumber == 5) Day = "Пятница";
if (dayNumber == 6) Day = "Суббота";
if (dayNumber == 7) Day = "Воскресенье";

Console.Write($"Сегодня: {Day}");