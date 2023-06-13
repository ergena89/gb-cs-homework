// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        Console.Write($"[{i},{j}] = {arr[i,j]}  ");
       }
       Console.WriteLine();
    }
    Console.WriteLine();
}
// вычисляем сумму в каждой строке и записываем в новый массив (из сумм строк)
int[] SummaInRows(int[,] arr)
{
    int[] sumarr = new int[arr.GetLength(0)];
    int summa = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summa = 0;
        for (int j  = 0; j < arr.GetLength(1); j++)
    {   
        summa = summa + arr[i,j];
        sumarr[i] = summa;
    }
    }
return sumarr;
}

// вычисляем наименьшую сумму и выводим ее номер и значение в консоли

int GetMinIndex(int[] sumarr)
{
    int minIndex = 0;
	int minValue = sumarr[0];

	for (int i = 0; i < sumarr.Length; i++)
    {
        if (sumarr[i] < minValue)
		{
			minValue = sumarr[i];
			minIndex = i;
		}
    }
    Console.WriteLine($"Минимальная сумма в строке {minIndex} = {sumarr[minIndex]}");
    return minIndex;

}

// решение
// создаем массив
// выводим в консоль
// вычисляем сумму в каждой строке
// создаем массив из данных сумм строк, выводим в консоль
// вычисляем наименьшую сумму и выводим ее номер и значение в консоли

int[,] arr = CreateRandom2Array(4, 5, 0, 10);
Print2Array(arr);
int[] sumarr = SummaInRows(arr);
PrintArray(sumarr);
int minIndex = GetMinIndex(sumarr);