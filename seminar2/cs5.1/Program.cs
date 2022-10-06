// программа, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int numx = Math.Abs(x);
int num1 = numx / 10;
int num2 = num1 % 10;

if (num1 / 10 < 99 && num1 / 10 > 1 )
{
    Console.WriteLine($"средняя цифра:{num2}");
}
else
{
    Console.WriteLine("ошибка ввода");
}


