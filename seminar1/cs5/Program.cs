// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.Write("Введите число 1 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 : ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
   Console.Write($"{a} больше,чем {b}");
}
if(b > a)
{
   Console.Write($"{b} больше {a}");
}
if(a == b)
{
   Console.Write("Вы ввели два одинаковых числа"); 
}