/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. 

Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] myArray =  {
                   {3, 2, 1, 0, 4, 5, 3},
                   {1, 9, 7, 3, 0, 1, 8},
                   {1, 3, 8, 1, 0, 1, 7}
                   };
void PrintArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {

        for (int j = 0; j < box.GetLength(1); j++)
        {
            Console.Write($"{box[i, j]}\t");

        }
        Console.WriteLine(); // абзац
    }
}

PrintArray(myArray);
Console.WriteLine();

void SumAv(int[,] box)
{
    //double sum = 0; // если поставить здесь, то сумма будет накапливать все элементы всех строк
    for (int i = 0; i < box.GetLength(1); i++)
    {
        double sum = 0; // если стоит здесь , то перед каждой новой строкой сумма обнуляется
        for (int j = 0; j < box.GetLength(0); j++)
        {
            sum = sum + box[j, i];
        }

        Console.Write($" среднее арифметическое элементов {i + 1} столбца равно: {sum / box.GetLength(0)}\t");
        Console.WriteLine();
    }

}
SumAv(myArray);




