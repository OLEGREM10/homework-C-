//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int i = 1;
int deg = 1;

while(i <= num2)
{
    deg = deg * num1;
    i++;
}
Console.WriteLine($"{num1} в {num2} степени = {deg} ");