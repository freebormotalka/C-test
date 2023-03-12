// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

int evenNumber = 2;

if (number > 1)
{
    while (evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}