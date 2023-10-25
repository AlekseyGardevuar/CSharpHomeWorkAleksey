/*
42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Clear();
//num = 10
int DecToBinary(int num)
{
    int result = 0;
    int temp = 1;
    while(num > 0)
    {
        result = result + num % 2 * temp; // 0 10 10 1010
        num = num / 2; // 5 2 1
        temp = temp * 10; // 10 100 1000
    }

    return result;
}


int num = 10;

System.Console.WriteLine(DecToBinary(num));

/*void InBinaryCode(int numb)
{
    string result = "";
    int binary = 0;
    for (int i = numb; i > 0; i/=2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.Write(result);
}
InBinaryCode(10);*/