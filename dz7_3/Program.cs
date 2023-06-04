// See https://aka.ms/new-console-template for more information
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//методы
int[,] CreateRandom2Array(int rows,int col,int from, int to)
{
  int[,] resultArray = new int[rows,col];
  Random rand = new Random();
 for (int i = 0; i < resultArray.GetLength(0); i++)
     {
        for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                resultArray[i,j] = rand.Next(from, to);
            }
     }
return resultArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Print2Array(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.WriteLine($" arr[{i},{j}] = {arr[i,j]}  ");
       }
    }
    Console.WriteLine();
}

// решение
// создаем рандом массив 3 на 4
// ищем среднее арифметическое каждого столбца
// выводим среднее арифметическое столбцов на экран

int[,] Arr = CreateRandom2Array(3, 4, 0, 10);
Print2Array(Arr);
int k = Arr.GetLength(0);
int summa = 0;
double middle = 0;
Console.Write($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < Arr.GetLength(1); j++)
{
    int[] column = new int[Arr.GetLength(0)];
    for (int i = 0; i < Arr.GetLength(0); i++)
    {   
        column[i] = Arr[i,j];
        summa = summa + Arr[i,j];
    }
    // проверка подсчет среднегоарифметического колонок
    // System.Console.WriteLine($"Столбец {j}:");
    // PrintArray(column);
    middle = (summa/(double)k);
    Console.Write($"{middle:0.00} ");
}