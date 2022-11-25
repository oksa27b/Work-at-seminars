// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

int  num = new Random ().Next(100,100000);
Console.WriteLine(num);
int result =0;
while(result==0)
{
    if (num>99&&num<1000)
    {
        result= num %10;
    }
    num/=10;

}
Console.WriteLine(result);
