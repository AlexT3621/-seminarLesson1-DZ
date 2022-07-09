/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());
int max = 1;
if (a > b)
{
    max = a ;
}
if (b != a & b > a)
{
    max = b;
}
if (a == b)
{
    max = a;
}

if (c > max)
{
    max = c;
}
if (c == max)
{
    max = c;
}
Console.WriteLine(max);