//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число"); // просим пользователя ввести первое число  
int numA = Convert.ToInt32(Console.ReadLine());  //пользователь вводит число

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;  // определяем первое число как максимальное

if(numB > max)  // сравниваем второе число с max
{
    max = numB;  // если условие верно в max помещаем значение второго числа
}

if(numC > max) // сравниваем третье число с max
{
    max = numC;
}
Console.WriteLine($"максимальное число {max}"); // выводим значение max