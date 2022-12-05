﻿// Задача 67: Напишите программу, которая 
// будет принимать на вход число и возвращать
//  сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(SumNum(n));

int SumNum(int n)
{
    if (n==0)
    {
        return 0;
    }
    return(n%10+SumNum(n/10));
   
}
