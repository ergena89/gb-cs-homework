// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число a =");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число c =");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b)
{
    if (a > c )
        max = a;
    else
        max = c;
}
else
{
    if (b > c )
        max = b;
    else
        max = c;
}
System.Console.WriteLine($"max = {max}");