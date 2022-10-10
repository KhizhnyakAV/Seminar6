// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
System.Console.WriteLine("Введите k1:");
double k1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b1:");
double b1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите k2:");
double k2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b2:");
double b2 = double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
x = Math.Round(x,2);
double y = k1*x+b1;
y = Math.Round(y,2);

System.Console.WriteLine($"({x};{y})");