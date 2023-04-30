// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели от 1 до 7: "); 
int den = Convert.ToInt32(Console.ReadLine());
if (den > 5)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}