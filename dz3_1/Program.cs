// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число!");
int num = Convert.ToInt32(Console.ReadLine());
int[] result = new int[5];

//записать все цифры числа в массив
int div = num;
int mod = 0;
int index = 0;
while (index < 5)
{
    mod = div%10;
    div = div/10;
    result[index] = mod;
    Console.WriteLine($"result[{index}] = {result[index]}");
    index++;
}

bool Palindrom = true;

for (int i = 0; i < 2; i++)
{
    if (result[i] != result[5-i-1])
    {
        Palindrom = false;
        break;
    }
}

if (Palindrom)
{
    Console.WriteLine($"Да");
}   
else  
{
   Console.WriteLine($"Нет");
}