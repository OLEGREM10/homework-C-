// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49




const int ROWS_COUNT1 = 4;
const int COLUMNS_COUNT1= 4;
const int LEFT_RANGE1 = 1;
const int RIGHT_RANGE1 = 10;

const int ROWS_COUNT2 = 4;
const int COLUMNS_COUNT2= 4;
const int LEFT_RANGE2 = 1;
const int RIGHT_RANGE2 = 10;



int[,] ourFirstMatrix = FirstFillMatrix(ROWS_COUNT1, COLUMNS_COUNT1, LEFT_RANGE1, RIGHT_RANGE1);   // матрица в переменой ourMatrix 
FirstPrintMatrix(ourFirstMatrix );
Console.WriteLine();

int[,] ourSecondMatrix = SecondFillMatrix(ROWS_COUNT2, COLUMNS_COUNT2, LEFT_RANGE2, RIGHT_RANGE2);
SecondPrintMatrix(ourSecondMatrix);
Console.WriteLine();

MultiplyMatrix(ourSecondMatrix);







int[,] FirstFillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next( leftRange,rightRange ) ;
        }
    }

    return matrix;
}

void FirstPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[ i, j ] + " " );
        }
        Console.WriteLine();
    }
}

int[,] SecondFillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = rand.Next( leftRange,rightRange ) ;
        }
    }

    return matrix;
}

void SecondPrintMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write(matrix[ m, n ] + " " );
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int m = 0; m < matrix.GetLength(0); m++)
      {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
          Console.WriteLine(  matrix[i,j] * matrix[m,n] + " ") ;
        }
        
      }
    }

   }


}



