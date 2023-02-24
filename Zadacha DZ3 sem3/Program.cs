/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


//1.
/*Console.Clear();
Console.WriteLine("Введите число N: ");
 int N = int.Parse(Console.ReadLine());
int[] result = new int[N];
for (int i = 1; i <= N; i++)
    result[i - 1] = i * i * i;
for (int i = 0; i < N; i++)
    Console.WriteLine($"{result[i]} ");*/



//2.
Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];
double d = 0;
for (int i = 0; i < n; i++)
{
    array[i] = i + 1;
    d = Math.Pow(array[i],3);
    Console.WriteLine(d);
}