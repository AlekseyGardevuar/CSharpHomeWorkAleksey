/*
который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
*/

Console.Clear();

/*
System.Console.Write("Задай число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000; 
System.Console.WriteLine(n1);
int n2 = n / 1000 % 10;
System.Console.WriteLine(n2);
int n4 = n / 10 % 10;
System.Console.WriteLine(n4);
int n5 = n % 10;
System.Console.WriteLine(n5);

if (n>=10000 & n <= 99999)
{
    if (n1 == n5 & n2 == n4)
    {
        System.Console.WriteLine("Yes!");
    }
    else
    System.Console.WriteLine("No!");
}
else
{
    System.Console.WriteLine("Это не пятизначное число!");
}
*/

System.Console.Write("Задай число: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i = i / 10)
{
    revN = revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if (N == revN)
{
    System.Console.WriteLine("Число палиндром!");
}
else
    System.Console.WriteLine("Число не палендром!");