// Показать числа от -N до N

using System;

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count < (N+1)){
    Console.Write(count + ", ");
    count++;
}

