// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] array = new int [123];
int count =0 ;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 50);

    if(array[i] > 10 & array[i] < 100)
    {
        count++;
    }

}
Console.WriteLine(string.Join("," , array));

Console.Write(count);



// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)  // метод возвращает массив на size элементов
// {
//     int[] array = new int[size];  //задаем массив на size элементов

//     Random random = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange +1);

//     }

//     return array;

// }