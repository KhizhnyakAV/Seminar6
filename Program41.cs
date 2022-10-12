// See https://aka.ms/new-console-template for more information
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Введите числа (окончание ввода - пустой ввод)");

int count = 0;


for (int i = 1; i < 1000000; i++)
{
    string s = Console.ReadLine();
    if (s == "")
    {
        break;
    }
    else
    {
        int number = int.Parse(s);
        if (number > 0)
        {
            count++;
        };
    }
}

System.Console.WriteLine(count);
