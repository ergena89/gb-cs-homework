// See https://aka.ms/new-console-template for more information

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Print2Array(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.WriteLine($" arr[{i},{j}] = {arr[i,j]} ");
       }
    }
    Console.WriteLine();
}

// решение
// запрашиваем позицию элемента
// выводим параметры искомого элемента
// создаем рандом массив 6 на 7
// ищем искомый элемент в нашем массиве и выдаем результат или говорим что такого нет


Console.Write("Введите позицию строки элемента массива i = ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца элемента массива j = ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели a[{i},{j}]");
int[,] Arr = CreateRandom2Array(6, 7, -100, 100);
Print2Array(Arr);
if (i <= Arr.GetLength(0) && j <= Arr.GetLength(1))
Console.WriteLine($"Arr[{i},{j}] = {Arr[i,j]} ");
else
Console.WriteLine($"Arr[{i},{j}] - такого элемента нет");