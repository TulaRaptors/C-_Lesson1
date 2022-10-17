// По двум заданным числам проверять является ли первое квадратом второго
using System;

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == Math.Pow(numberB, 2))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ квадрат второго");
}
