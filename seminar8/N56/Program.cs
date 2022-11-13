//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов масива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
void FillArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            box[i, j] = new Random().Next(-10, 15);
        }
    }
}

void PrintArray(int[,] box)
{
    for (int i = 0; i < box.GetLength(0); i++)
    {
        for (int j = 0; j < box.GetLength(1); j++)
        {
            Console.Write($"{box[i, j]} \t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();


int[] res1 = new int[m];  //массив для хранения сумм строк
int summ1 = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        summ1 += array[i, j]; 
    }
    res1[i] = summ1;
    summ1 = 0;
}

int min = 0;  
for (int j = 1; j < m; j++)
{
    if (res1[j] < res1[min])   
        min = j;
}

Console.WriteLine();
Console.WriteLine($"наименьшую сумму элементов ({res1[min]}) имеет {min+1} строка ");
Console.WriteLine();

