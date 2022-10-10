//  Задача 21: Напишите программу, которая принимает на 
//  вход координаты двух точек и находит расстояние между 
//  ними в 3D пространстве. 

Console.Write("Введите координаты первой точки по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) +
                          Math.Pow(y1 - y2, 2) +
                          Math.Pow(z1 - z2, 2));
 Console.WriteLine($"Расстояние между точками равно: { Math.Round(result)}");
 