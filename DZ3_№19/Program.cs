/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/

int n, r, sum = 0, t;
Console.Write("Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out n);
if (n > 9999 && n < 100000)
{
    for (t = n; n != 0; n = n / 10)
    {
        r = n % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write($"{t} является палиндромом.");
    else
        Console.Write($"{t} не является палиндромом.");
}
else
    Console.Write("Введите пятизначное число!");