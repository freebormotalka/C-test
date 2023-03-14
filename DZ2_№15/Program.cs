//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int n;
Console.Write($"Введите день недели: ");
int.TryParse(Console.ReadLine()!, out n);
if (n > 7)
{
    Console.Write($"Нет такого дня недели");
}
if (n < 6)
{
    Console.WriteLine($"Рабочий день");
}
else if (n == 6)
{
    Console.Write($"Суббота");
}
else if (n == 7)
{
    Console.Write($"Воскресенье");
}