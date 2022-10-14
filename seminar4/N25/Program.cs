// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = 1;
int rez = A;
while(count < B )
{
    rez = rez * A;
    count++;
}

Console.WriteLine($"число {A} в степени {B} равно {rez}");
