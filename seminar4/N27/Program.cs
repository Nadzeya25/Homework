// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму ЦИФР в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

void Summ(int A)
{
    int count = 0;
    while (A > 1)
    {
        int ost = A % 10;
        count = count + ost;
        A = A / 10;
    }

    Console.Write(count);
}

Summ(A);
