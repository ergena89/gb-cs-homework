// See https://aka.ms/new-console-template for more information
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.

// метод создания массива
int[] CreateRandomIntArray(int size,int from, int to)
{
   Random arr = new Random();
   int[] resultArray = new int[size];
   for (int i = 0; i < size; i++)
   {
      resultArray[i] = arr.Next(from, to);
   }
   return resultArray;
}

// метод вывода массива для просмотра
void PrintIntArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      Console.Write($"{arr[i]} ");
   }
   Console.WriteLine();
}

// метод определения количества четных элементов в массиве
int CountHonest(int[] arr)
{
   int res = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      if (IsHonest(arr[i]))
         res++;
   }
   return res;
}

// метод проверки числа на четность
bool IsHonest(int n)
{
   if (n % 2 == 0)
      return true;
   return false;
}

//решение задачи с использованием методов
int[] rand = CreateRandomIntArray (7,100,999);
PrintIntArray(rand);
int countHohest = CountHonest(rand);
Console.WriteLine($"кол-во чётных элементов в массиве = {countHohest}");

