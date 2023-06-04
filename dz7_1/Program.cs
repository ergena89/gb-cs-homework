// See https://aka.ms/new-console-template for more information
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//методы
double[,] CreateRandom2Array(int rows,int col,int from = -100, int to = 100)
{
  double[,] resultArray = new double[rows,col];
  Random rand = new Random();
 for (int i = 0; i < resultArray.GetLength(0); i++)
     {
        for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                resultArray[i,j] = Convert.ToDouble(rand.Next(from, to)/10.0);
            }
     }
return resultArray;
}

void Print2Array(double[,] arr)
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
Console.Write("Введите количество строк массива m = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n = ");
int col = int.Parse(Console.ReadLine());
double[,] arr = CreateRandom2Array(rows, col);
Print2Array(arr);
