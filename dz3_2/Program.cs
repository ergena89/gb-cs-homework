// See https://aka.ms/new-console-template for more information
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// забираем координаты точки A
Console.Write("Введите координаты точки A: x =");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A: y =");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A: z =");
double az = Convert.ToDouble(Console.ReadLine());
// забираем координаты точки B
Console.Write("Введите координаты точки B: x =");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: y =");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: z =");
double bz = Convert.ToDouble(Console.ReadLine());
// находим расстояние между точками A и B
double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)+ Math.Pow(az - bz, 2));
Console.Write($"Расстояние между точками = {result}");