﻿// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = -N;

while ( x <= N )
{
    Console.Write("Целые числа: ");
    Console.WriteLine(x);
    x = x + 1;
}
