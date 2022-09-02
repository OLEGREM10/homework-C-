// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//  возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

const int ROWS_COUNT = 5;
const int COLUMNS_COUNT= 5;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());  // номер строки 

Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());  // номер  столбца

int[,] ourMatrix = FillMatrix(ROWS_COUNT, COLUMNS_COUNT,LEFT_RANGE, RIGHT_RANGE );
PrintMatrix(ourMatrix);
ValuePosition(ourMatrix);

int[,] FillMatrix(int rowsCount,int columnsCount,int leftRange,int rightRange)
{
    int[,] matrix = new int [rowsCount,columnsCount];

    Random rand = new  Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange,rightRange);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

void ValuePosition(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == m && j == n)
            {
                Console.WriteLine(ourMatrix[i,j]);
            }
            if(i != m & j != n)
            {
                Console.WriteLine($"{m}{n} Такого элемента в массиве нет");
            }
        } 
         

    }
     
           
}    
        
    