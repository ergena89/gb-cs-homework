// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//методы

void OutputNatNum(int n)
{
    if (n == 1)
    {   
        Console.Write($"1.");
    }
    else
    {
    Console.Write($"{n}, ");
    OutputNatNum(n-1);
    }
}

//решение
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
OutputNatNum(n);