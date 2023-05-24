// See https://aka.ms/new-console-template for more information
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень B = ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
// создаем цикл в котором введенное число (А) умножается само на себя, до тех пор, пока i не станет равной степени (В)
for (int i = 0; i < B; i++)
{
    result = (result*A);
}
Console.WriteLine($"Степень = {result}");
