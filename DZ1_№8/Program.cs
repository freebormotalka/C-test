﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int evenN = 2;

if (N > 1)
{
    while (evenN <= N)
    {
        Console.Write(evenN + " ");
        evenN = evenN + 2;
    }
}