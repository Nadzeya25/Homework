// программа, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int num1 = x / 10;
int num2 = num1 % 10;

if(num1 / 10 > 1 && num1 / 10 <10 )
{
     Console.WriteLine($"средняя цифра:{num2}");
}
else
{
    Console.WriteLine("ошибка ввода"); 
}

