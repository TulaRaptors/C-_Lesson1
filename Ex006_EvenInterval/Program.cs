// Показать четные числа от 1 до N

using System;

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < (N+1)){
    Console.Write(count + ", ");
    count = count + 2;
}
