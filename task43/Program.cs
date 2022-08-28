﻿// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Даны уравнения двух прямых: y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

double CrossLineX(double b1, double k1, double b2, double k2)
{
    x = (b2 - b1) / (k1 - k2);
    return Math.Round(x = (b2 - b1) / (k1 - k2), 2);
}

double CrossLineY(double b1, double k1, double b2, double k2)
{
    y = (k2 * (b2 - b1) / (k1 - k2)) + b2;
    return Math.Round(y = ((k2 * (b2 - b1) / (k1 - k2)) + b2), 2);
}


if(k1 == k2 && b1 == b2)
{
    Console.WriteLine($"Прямые совпадают и имеют бесконечное количество решений");
}
else if(k1 == k2)
{
    Console.WriteLine($"Прямые параллельны другу друг и не имеют точек пересечения");
}

else

Console.Write($"Прямые пересекаются в точке ({CrossLineX(b1, k1, b2, k2)}; {CrossLineY(b1, k1, b2, k2)})");






