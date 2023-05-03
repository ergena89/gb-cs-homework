// See https://aka.ms/new-console-template for more information
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
double rez = 0;
while (index <= num)
{
    rez = Math.Pow(index, 3);
    Console.WriteLine($"{rez}");
    index++;
}