// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
using System;

Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine("Дано число: " + number);
int digit1 = number / 10;
int digit2 = number % 10;
int max = digit1;
if (digit2 > max){
    max = digit2;
}
Console.WriteLine("Наибольшая цифра: " + max);