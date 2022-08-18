//Задача 21
//Напишите программу, которая принимает на вход координаты трёх
// точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.5


Console.WriteLine("Введите координату точки А по X");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А по Y");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Z");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по X");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Y");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Z");
int zb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xa-xb ,2) + Math.Pow(ya - yb ,2) + Math.Pow(za - zb ,2));

Console.WriteLine($"{res:f2}");

