//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int i;
Console.Write($"Введите число ");
int.TryParse(Console.ReadLine()!, out i);
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine($"Сумма всех цифр в числе равна: {sum}");