﻿// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());

bool b = false;

int [] array = {-8,5,78,-5432,-11};

for (int i = 0; i < array.Length; i++)
{
    if(array[i]==num)
    {
        b=true;
    }
}
if (b==true)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("Нет");
}