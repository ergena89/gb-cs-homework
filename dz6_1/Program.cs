// See https://aka.ms/new-console-template for more information
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// методы

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] ReadInputArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Задайте элемент массива a[{i}] = ");
        int member = Convert.ToInt32(Console.ReadLine());
        arr[i] = member;
    }
    return arr;
}


// решение задач
Console.Write("Введите количество вводимых чисел М = ");
int m = Convert.ToInt32(Console.ReadLine());

//запрашиваем элементы массива у пользователя
int[] nums = ReadInputArray(m);

//выведем массив на экарн
Console.WriteLine("Вы ввели массив: ");
PrintArray(nums);

int countPositive = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0)
    {
        countPositive ++;
    }
}
Console.WriteLine($"количество чисел больше 0 = {countPositive}");

