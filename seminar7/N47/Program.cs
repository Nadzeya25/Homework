//задача47. Задайте двумерный массив размером m x n ,
// заполненный случайными веещественными числами

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();// для красоты абзац

void FillArray(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 30, 2); 
                                              // для красоты умножила на 30 и округлила до сотых
        }      
    }
}
void PrintArray(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        
        Console.WriteLine(); //обязательный абзац
    }
}

double[,] box = new double[m, n];
FillArray(box);
PrintArray(box);
Console.WriteLine();// абзац для читаемости в консоли