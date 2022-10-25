// задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет. 



void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }

        Console.WriteLine();
    }
}
int[,] myArray =  {
                   {3, 2, 8, 0, 7, 5,-3},
                   {1, 9, -7, -3, 0, 1, 8},
                   {11, 93, -8, -1, 0, 1, 7}
                   };
PrintArray(myArray);
// Console.WriteLine($"количество строк : {myArray.GetLength(0)} ");
// Console.WriteLine($"количество столбцов : {myArray.GetLength(1)} ");


Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

if ( rows > myArray.GetLength(0)
   ||rows < 1 
   ||columns > myArray.GetLength(1) 
   ||columns < 1
)
{
    Console.WriteLine("Такого элемента нет ");
}
else
{
    Console.WriteLine($"по заданным координатам находится элемент : {myArray[rows-1, columns-1]} ");
}






