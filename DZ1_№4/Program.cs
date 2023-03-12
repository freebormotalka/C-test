// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int max = 0;
int a, b, c;

Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write($"max = {max}");