//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 100 & num < 1000)
{
int num1 = num % 10;
  Console.WriteLine($"третья цифра числа {num} цифра {num1}");
  
}
if(num < 100)
{
    Console.WriteLine($"У числа {num} третьей цифры нет");
    
}


    







    
