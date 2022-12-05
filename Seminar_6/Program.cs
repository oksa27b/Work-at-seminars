// Console.Clear();
// Console.WriteLine("Введите желаемое кол-во элементов массива N ");
// Console.Write(" N =  ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[] num = SetArrayRealNumbers(n);

// double min = num[0];
// double max = num[0];

// for (int i = 0; i < n; i++)
// {
//     if (num[i] >= max)
//     {
//         max = num[i];
//     }
//     else if (num[i] <= min)
//     {
//         min = num[i];
//     }
// }

// Console.Write(String.Join("; ", num));

// Console.WriteLine();

// Console.WriteLine($" В данном массиве разница между максимальным ({max}) и минимальным ({min})\n элементом с учетом знака будет равна max - min  = {Math.Round((max - min), 2)}");

//  double[] SetArrayRealNumbers (int n)
// {
//     double[] num = new double[n];

//     for (int i = 0; i < n; i++)
//     {
//         num[i] = new Random().Next(100, 1000) + new Random().NextDouble();

//         num[i] = Math.Round(num[i], 2);
//     }
//     return num;
// }



// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] num = new double[size];
// FillArrayRandomNumbers(num);
// Console.Write("Вот наш массив: ");
// PrintArray(num);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;
//  for (int j = 0; j < num.Length; j++)
//  { if (num[j] > max) 
//     { max = num[j]; 
//     } 
//     if (num[j] < min) 
//     { min = num[j];
//      }} 
// Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
//  void FillArrayRandomNumbers(double[] num)
//  { for(int i = 0; i < num.Length; i++)
//   { num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100; 
//   }
//   }
//   void PrintArray(double[] num)
//   { Console.Write("[ "); for(int i = 0; i < num.Length; i++) 
//   { Console.Write(num[i] + " "); 
//   } Console.Write("]"); Console.WriteLine();
//   }


// double[] CreateArray (int size, double min, double max)
// {
//     double[] array = new double [size];
//     for (int i = 0; i < size; i++)
//    {
//       array[i] = (new Random().NextDouble()) * (max - min) + min;
//    }
//    return array;
// }

// double [] array = CreateArray(20,-100,100);

// Console.WriteLine(String.Join(« «, array));

// double DiffMaxMin (double [] array)
// {
//     double max = array [0];
//     double min = array [0];
//     double diff = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//            max = array[i];
//         }
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return max - min;
// }

// double diff = DiffMaxMin(array);
// diff = Math.Round(diff, 2);
// Console.WriteLine(«Разница между максимальным и минимальным «+ diff);













// Задача 42: Напишите программу, которая будет
//  преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

string result ="";
while(n>0)
{
    result=n%2+result;

    n/=2;

}
Console.Write(result);





