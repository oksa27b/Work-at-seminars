﻿// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в
//  целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Pow(n,m));

int Pow(int n,int m)
{
    if (m==0)
    {
        return 1;
    }
     if (m==1)
    {
        return n;
    }
    return(n*Pow(n,m-1));
   
}


