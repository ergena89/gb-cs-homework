// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());
int length = 0;
int ost = num;
double result = 0;

if (num > 99)
{
        while (ost!=0)
    {
       ost = ost/10;
       //System.Console.WriteLine($"ost: {ost}");
       length++;
    }
    // System.Console.WriteLine($"length: {length}");
    // System.Console.WriteLine($"Math.Truncate((num / Math.Pow(10,length-3)))={Math.Truncate((num / Math.Pow(10,length-3)))}");
    result = (Math.Truncate((num / Math.Pow(10,length-3)))%10);
    Console.WriteLine($"{result}");
}
else
{
        Console.WriteLine($"Нет третьей цифры");
}