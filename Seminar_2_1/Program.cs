﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно


int num1 = new Random().Next(10,100);
int num2 = new Random().Next(10,100);

Console.WriteLine(num1);

Console.WriteLine(num2);

if (num1>num2)
{
    if (num1%num2==0)
{
    Console.WriteLine("Чило "+ num1+" кратно числу " +num2);
}
}
    else
{
    Console.WriteLine("Остаток от деления "+num1%num2);
}


