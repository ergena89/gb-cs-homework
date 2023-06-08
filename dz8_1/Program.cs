// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        Console.Write($"Row {i}: ");
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.Write($"{arr[i,j]} ");
       }
       Console.WriteLine();
    }
    Console.WriteLine();
}

//решение
int[,] arr = CreateRandom2Array(3, 4, 0, 10);
Print2Array(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    int colCount = arr.GetLength(1);
    PrintArray(arr, i);
    for (int j = 0; j < colCount; j++)
    {
        //найти максимальный и поменять местами
        int max = arr[i,j];
        int maxIndex = j;
        for (int x = j;x < colCount; x++)
        {
            if (max < arr[i,x])
            {
                max = arr[i,x];
                maxIndex = x;
            }
        }
        //поменяю местами
        if (maxIndex != j)
        {
            int current = arr[i,j];
            arr[i,j] = max;
            arr[i, maxIndex] = current;
        }
    }
    PrintArray(arr, i);
    Console.WriteLine();
}
Print2Array(arr);
         

void PrintArray(int[,] arr, int i)
{
    Console.Write($"Row {i}:");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}


