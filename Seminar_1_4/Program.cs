﻿// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке -N до N.

// 4 ->"-4, -3,-2, -1, 0, 1, 2, 3, 4"
// 2 ->"-2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int negNum=- num;

while(negNum<=num)
{
    Console.WriteLine(negNum);
    // Console.Write(negNum);
    negNum++;
}
