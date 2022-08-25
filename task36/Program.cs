// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int sumnumbers = 0;
//int index = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 21);
    while(i % 2 != 0)
    {
        sumnumbers += array[i];
        i++;
    }
    

}
Console.Write(string.Join("," , array));
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел = {sumnumbers}");