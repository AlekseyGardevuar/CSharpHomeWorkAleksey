/*using System;

namespace Hal
{
   class Program
    {
        static void Main(string[] args);
        {
            Console.WriteLine("Ввудите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());

        if (sum < 100)
        {
            sum += sum * 0.05;
        }
        else if (sum <=200)
        {
            sum += sum * 0.07;
        }
        else
        {   
            sum += sum * 0.1;
        }
        Console.WriteLine ($"сумма вклада после начисления процентов: {sum}");

        Console.ReadKey();

        }
    }
}*/

Console.Clear();

double a = 6;
double b = 0.5;
double c = 0;

a /= a * b;
System.Console.WriteLine(a);
