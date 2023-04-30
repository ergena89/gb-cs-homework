// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: "); 
int num = Convert.ToInt32(Console.ReadLine());
int rez = Math.DivRem(num%100,10,out int result);
Console.WriteLine(rez);