﻿// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int c = 1;
while (c<=n)
{
  Console.WriteLine(c*c);
  c++;
}
