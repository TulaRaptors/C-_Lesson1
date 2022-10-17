// Показать последнюю цифру трёхзначного числа

using System;

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string str = Convert.ToString(number);

if (str.Length  == 3) {
    int lastdigit = str[str.Length - 1] - '0';
    Console.WriteLine("Последняя цифра числа: " + lastdigit);
}
else{
    Console.WriteLine("Число не является трехзначным!");
}
