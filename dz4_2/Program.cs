// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
int b = 0;
for (int i = 0; i <= a; i++)
{
    b = a%10;
    a = a/10;
    result = result + b;
}
Console.WriteLine($"сумма равна = {result}");
