﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число, чтобы узнать чётное оно или нечётное"); // просим ввести пользователя число
int num = Convert.ToInt32(Console.ReadLine());   //  пользователь вводит число

int mod = num % 2;  // при делении получаем целый остаток

if(mod == 0) // сравниваем целый остаток с нулем
{
    Console.WriteLine($"{num} чётное число ");  // если условие верно выводим ,что число чётное
}
else
{
    Console.WriteLine($"{num} нечётное число"); // если условие ложно выводим ,что число нечётное
}