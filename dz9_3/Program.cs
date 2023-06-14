// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//методы

int AkermanFunc(int m, int n)
{
    int rezult = 0;
    if(m == 0)
    {
        rezult = n + 1;
    }
    else if (m > 0 && n == 0)
        {
            rezult = AkermanFunc(m - 1, 1);
        }
    else if(m > 0 && n > 0)
        {
            rezult = AkermanFunc((m - 1), AkermanFunc(m, n - 1));
        }
    return rezult;
}
  
//решение

Console.Write("Введите неотрицательное число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n = ");
int n = Convert.ToInt32(Console.ReadLine());
int rez = AkermanFunc(m, n);
Console.WriteLine($"Функция Аккермана A(m,n) = {rez}");

