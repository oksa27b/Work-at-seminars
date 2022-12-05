// ДЗ


Console.Write("Сколько чисел вы хотите ввести? ");
int numb = Convert.ToInt32(Console.ReadLine());
int[] array = new int [numb];

int PositiveCount(int count)
{
    int countOfPositive = 0;
    for(int i = 0; i < count;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countOfPositive+=1;
        }
        Console.WriteLine(string.Join(",", array));
    }
    return countOfPositive;
}
int posCount = PositiveCount(numb);
Console.Write($"количество положительных чисел = {posCount}");



// int totalNegativeNumbers = 0;
// bool b = true;
// while (b)
// {
//     Console.Write("Хотите ввести число? Если  ДА наберите  1: ");

//     int n = Convert.ToInt32(Console.ReadLine());

//     if (n == 1)
//     {
//         Console.Write("Введите число: ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         if (m > 0)
//         {
//             totalNegativeNumbers = totalNegativeNumbers + 1;
//         }
//     }
//     else
//     {
//         Console.Write($"Спасибо! Чисел больше 0 введено {totalNegativeNumbers} раз");
//         b = false;
//     }
// }
