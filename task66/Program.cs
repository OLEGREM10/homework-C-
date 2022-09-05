// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum(int M, int N)
            {
                if (M > N) return 0;
                else return M + Sum(M + 1,N);
            }
             Console.WriteLine(Sum(4,8));

        }

    }
}