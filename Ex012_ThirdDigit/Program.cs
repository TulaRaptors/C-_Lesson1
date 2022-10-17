// Найти третью цифру числа или сообщить, что её нет

using System;

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(Math.Abs(number));

if (str.Length >= 3) {
    Console.WriteLine("Третья цифра числа " + number + ": " + str[2]);
}
else{
    Console.WriteLine("В числе меньше трех цифр!");
}