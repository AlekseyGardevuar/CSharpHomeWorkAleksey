/*
который принимает на вход число (N) и выводит таблицу кубов чисел 
от 1 до N (включительно) каждое на новой строке.
*/ 

Console.Clear();
System.Console.Write("Введите число N: ");
double number = int.Parse(Console.ReadLine());

for (double i = 1; i <= number; i++)
{
    double sqr = Math.Pow(i, 3);
    System.Console.WriteLine(sqr);
}