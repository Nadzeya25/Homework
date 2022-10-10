// Задача 19: Напишите программу, которая принимает на 
//  вход пятизначное число и проверяет, является ли оно 
//  палиндромом. 
//      12345
int x = 72127;

int x5 = x % 10;
int x1 = x / 10000;
int x2 = x / 1000 % 10;
int x4 = x / 10 % 10;

// Console.Write(x1);
// Console.Write(x2); 
// Console.Write("1");
// Console.Write(x4);
// Console.Write(x5);

if(x5 == x1 && x2 == x4)
{
   Console.WriteLine($" число {x} - это палендром"); 
}
else
    { 
           Console.WriteLine($" число {x} - это не палендром"); 
    }

