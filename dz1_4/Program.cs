// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число n =");
int n = Convert.ToInt32(Console.ReadLine());
int result = 2;
while (result <= n)
{
     Console.WriteLine($"четные числа:{result}");
     result+=2;
}
