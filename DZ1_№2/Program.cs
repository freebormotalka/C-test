// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max, min;
int a, b;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.Write($"max = {max} и min = {min}");