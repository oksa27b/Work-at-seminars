﻿// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает
// последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int result= num%10;
Console.WriteLine(result);