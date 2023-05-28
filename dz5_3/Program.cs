// See https://aka.ms/new-console-template for more information
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int LargeIntArray (int[] arr)
{
    int lar = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > lar){
        lar = arr[i];
    }
    }
    return lar;
}

int LittleIntArray (int[] arr)
{
    int lit = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < lit)
        {
        lit = arr[i];
        }
    }
    return lit;
}

// решение задачи
int lar = 0;
int lit = 0;
int[] arr = CreateRandomIntArray(5,0,100);
PrintArray(arr);
lar = LargeIntArray(arr);
Console.WriteLine($"максимальный = {lar}");
lit = LittleIntArray(arr);
Console.WriteLine($"минимальный = {lit}");
int res = lar-lit;
Console.WriteLine($"разница между максимальным и минимальным элементом массива = {res}");
