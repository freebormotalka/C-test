// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int min = 0;
Console.Write("Введите первое число: ");
int firstNumber = Console.ReadLine();

Console.Write("Введите второе число: ");
int secondNumber = Console.ReadLine();

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);