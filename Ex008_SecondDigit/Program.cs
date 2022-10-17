// Показать вторую цифру трёхзначного числа

using System;

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(Math.Abs(number));

if (str.Length  == 3) {
    Console.WriteLine("Вторая цифра числа " + number + ": " + str[1]);
}
else{
    Console.WriteLine("Число не является трехзначным!");
}
