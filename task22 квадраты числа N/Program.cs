/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
System.Console.WriteLine("Введите число N: ");
double number = int.Parse(Console.ReadLine());

for (double i = 1; i <= number; i++)
{
    double sqr = Math.Pow(i, 2);
    System.Console.Write(sqr);
    if(i < number)
        System.Console.Write(", ");
}

/*
System.Console.WriteLine("Введите число");

int num = int.Parse(System.Console.ReadLine());



for(int i = 1; i <= num; i++) System.Console.WriteLine((i < 10 ? " ": "") + $"{i} * {i} {(i < 10 ? " ": "")}= {i*i}");

// for(int i = 1; i <= num; i++) 
//    System.Console.WriteLine(i*i);

for(int i = 1; i <= num; i++) 
        System.Console.WriteLine($"{i} * {i} = {i*i}");
        
*/