// программа выводит третью цифру слева заданного числа или сообщает, что цифры нет

int x = 78;  //int x = new Random().Next();
Console.WriteLine(x);
int num = Math.Abs(x);//модуль ччисла
Console.WriteLine(num);

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("нет третьей цифры слева");
}

