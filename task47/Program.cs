// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int ROWS_COUNT = 2;
const int COLUMNS_COUNT= 2;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());  // Количество строк

// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());  // Количество столбцов

double[,] ourMatrix = FillMatrix(ROWS_COUNT, COLUMNS_COUNT, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(ourMatrix );


double[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() ;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
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



// double[,] a =new double[5,10];
// Random random = new Random();
// for (double i = 0; i < 5; i++)
// {
//     for (double j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }