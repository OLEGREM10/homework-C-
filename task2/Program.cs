//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число"); //просим пользователя ввести число
int numA = Convert.ToInt32(Console.ReadLine()); // пользователь вводит число

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

    if(numA > numB)  //сравниваем первое и второе число
    {
        Console.WriteLine($"{numA} больше \n{numB} меньше"); // выводим результат если условие верно
    }
    else
    {
        Console.WriteLine($"{numB} больше \n{numA} меньше");  // выводим результат если условие не верно
    }
