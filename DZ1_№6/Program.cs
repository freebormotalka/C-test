// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
int remDiv = number % 2;
if (remDiv == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не четное");
}
