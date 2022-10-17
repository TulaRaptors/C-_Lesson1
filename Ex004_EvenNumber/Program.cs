// Выяснить является ли число чётным

using System;

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0){
    Console.WriteLine("Число ЧЁТНОЕ");
}
else{
    Console.WriteLine("Число НЕЧЁТНОЕ");
}