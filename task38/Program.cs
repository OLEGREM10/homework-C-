// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [10];
double differens = 0;


for(int i = 0; i < array.Length; i++ )
{
    array[i] = new  Random().Next(1, 100);
}

double max = array[0];
double min = array[1];

for (int i = 0;i < array.Length;i++)
{
    if (array[i] > max)
    {
    max = array[i];

    }
    if (array[i] < min)
    {
        min = array[i]; 
    }
}
   
    



differens = (max - min);
Console.WriteLine(string.Join("," , array));
Console.WriteLine($"Разница между максимальным {max} и минамальным {min} = {differens}");
