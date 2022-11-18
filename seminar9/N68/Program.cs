// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число m >= 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n >= 0: ");
int n = Convert.ToInt32(Console.ReadLine());
int Akk(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
      if ((a != 0) && (b == 0))
        return Akk(a - 1, 1);
    else
        return Akk(a - 1, Akk(a, b - 1));
}
Console.WriteLine();
Console.WriteLine($"функция Аккермана равна {Akk(m, n)}"); 
