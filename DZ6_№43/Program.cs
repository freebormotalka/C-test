
//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1, b2, k1, k2, x, y ;
Console.Write($"Введите b1 ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write($"Ввкдите k1 ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write($"Введите b2 ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write($"Введите k2 ");
double.TryParse(Console.ReadLine()!, out k2);

x = (b1 - b2)/ (k2 - k1);
y = k2 * x + b2;

x = Math.Round(x,2);
y = Math.Round(y, 2);
Console.Write($"Пересечение в точке: ({x}; {y})");