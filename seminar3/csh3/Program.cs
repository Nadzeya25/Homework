//  Задача 23: Напишите программу, которая принимает на 
//  вход число (x) и выдаёт таблицу кубов чисел от 1 до x. 
Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел до {x}: ");
// while(i <= x)
// {
//     int result = i * i * i;
//     Console.Write($"{i}"); 
//     Console.WriteLine($"        {result}");
//     i++;
// }
for(int i = 0; i <= x; i++)
{
    int result = i * i * i;
    Console.Write($"{i}"); 
    Console.WriteLine($"        {result}");
}
