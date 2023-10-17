/*
30. Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];// = {1, 0, 1, 0, 1, 0, 1} - ввод определенного массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i]+ " ");
    }
}

System.Console.WriteLine("Задай размер масива:");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRnd(userSize);
PrintArray(userArray);