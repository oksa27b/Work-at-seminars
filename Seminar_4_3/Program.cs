// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int [] GetArray(int  size)
// {
//    int [] array1 = new int[size];

//    for (int i = 0; i < size; i++)
//    {
//     array1[i] = new Random().Next(0,2);
//    }
    
//     return array1;

// }
// int [] array = GetArray(8);

// Console.Write(array);

int [] GetArray(int [] array)
{
   
   for (int i = 0; i <array.Length; i++)
   {
    array[i] = new Random().Next(0,2);
   }
    
    return array;

}
// сначало 00000000 мы обращаемся к методу чтобы выполнить какое-то действие
int [] array = new int [8];
 GetArray(array);

Console.Write(String.Join(",", array));

