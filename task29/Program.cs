//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран


int [] numbers = new [] {4,7,8,2,4,7,9,7};
int i = 0;

while(i < numbers.Length)
{
    Console.Write(numbers [i] + " ");
    i++;
}