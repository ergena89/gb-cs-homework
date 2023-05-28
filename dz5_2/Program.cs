// See https://aka.ms/new-console-template for more information
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// методы
int[] CreateRandomIntArray(int size, int from, int to)
        {
            Random rand = new Random();
            int[] resultArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = rand.Next(from, to);
            }
            return resultArray;
        }

void PrintArray(int[] rand)
{
    for (int i = 0; i < rand.Length; i++)
    {
        Console.Write($"{rand[i]} ");
    }
    Console.WriteLine();
}

// Решение задачи
int[] rand = CreateRandomIntArray(7,0,20);
PrintArray(rand);
int res = 0;
for (int i = 0; i < rand.Length; i++)
{
    if (i % 2 != 0)
    res = res + rand[i];
}
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {res}");