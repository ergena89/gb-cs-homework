// See https://aka.ms/new-console-template for more information
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("создаем массив из 8 элементов и заполняем его рандомными числами от 0 до 100");
Random rand = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
   array[i] = rand.Next(0,100);
   Console.Write($"{array[i]} ");
}
