//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);
if (n >= 100)
{
    int third = n % 10;
    Console.WriteLine($"Третья цифра числа {n} является {third}");
}
else
{
    Console.Write($"Третьей цифры нет");
}

