// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int num1 = new Random().Next(10,100);
Console.WriteLine(num1);

//  bool tr = (num1%7==0)&&(num1%23==0);
// if(tr)

if ((num1%7==0)&&(num1%23==0)) 
{
    Console.WriteLine("Число " + num1 +"кратен 23 и 7");
}
else 
{
    Console.WriteLine("Нет");
}  


