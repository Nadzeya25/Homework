// программа принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным: да/нет
int x = new Random().Next(1, 8);
Console.WriteLine(x);
if(x == 6 || x == 7 )
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет"); 
}






