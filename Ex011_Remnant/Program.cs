// Выяснить, кратно ли число заданному, если нет, вывести остаток.
using System;

Console.Clear();
int a = 3;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % a == 0) {
    Console.WriteLine("Число кратно " + a);
}
else{
    Console.Write("Число не кратно " + a + ", остаток от деления: ");
    Console.WriteLine(number % a);
}
