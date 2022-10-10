// See https://aka.ms/new-console-template for more information
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Введите числа (окончание ввода - пустой ввод");

int count = 0;
while (Console.ReadLine() != "")
{
count++;
}

System.Console.WriteLine(count);