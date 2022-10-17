// По заданному номеру дня недели вывести его название

using System;

Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt16(Console.ReadLine());

if (number >=1 && number <=7) {
    if (number == 1){
        Console.WriteLine("ПОНЕДЕЛЬНИК");
    }
    if (number == 2){
        Console.WriteLine("ВТОРНИК");
    }
    if (number == 3){
        Console.WriteLine("СРЕДА");
    }
    if (number == 4){
        Console.WriteLine("ЧЕТВЕРГ");
    }
    if (number == 5){
        Console.WriteLine("ПЯТНИЦА");
    }
    if (number == 6){
        Console.WriteLine("СУББОТА");
    }
    if (number == 7){
        Console.WriteLine("ВОСКРЕСЕНЬЕ");
    }
}
else{
    Console.WriteLine("Такого дня недели не существует!");
}