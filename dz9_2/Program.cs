// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//методы

int Massive(int from, int to)
{
    if(from == to)
    {
        return from;
    }
    else
    {
        return from + Massive(from +1, to);
    }
}

//решение
Console.Write("Введите натуральное число m = ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n = ");
int to = Convert.ToInt32(Console.ReadLine());
if (from > to)
{
   (from,to) = (to,from);
}
int summa = Massive(from,to);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {summa}");