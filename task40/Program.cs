/*40. Напишите программу, 
которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.*/

Console.Clear();

bool Triangle(int num1, int num2, int num3)
{
    if(num1 <= 0 || num2 <= 0 || num3 <= 0) return false;
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}


System.Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число C: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(number1, number2, number3);
System.Console.WriteLine(result? "Треугольник существует": "Треугольник не существует");