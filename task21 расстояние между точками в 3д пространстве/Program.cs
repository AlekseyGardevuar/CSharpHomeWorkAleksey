/*
 который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел
 , и возвращает расстояние между ними в 3D пространстве.
*/

Console.Clear();
System.Console.Write("Задай координату точки A x:");
int userAX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A y:");
int userAY = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A z:");
int userAZ = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B x:");
int userBX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B y:");
int userBY = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B z:");
int userBZ = int.Parse(Console.ReadLine());

double sqrX = Math.Pow(userBX - userAX, 2);
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrZ = Math.Pow(userBZ - userAZ, 2);
double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ);
System.Console.WriteLine(Math.Round(sqrt, 2));
