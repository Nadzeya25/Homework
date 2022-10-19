//задача 34. Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве
void FillArray(int[] arr)
{
    int size = arr.Length;
    int index = 0;
    while (index < size)
    {
        arr[index] = new Random().Next(100, 1000);
        index++;

    }
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    int index = 0;
    while (index < size)
    {
        if (index < size - 1)
            Console.Write($"{arr[index]}, ");
        else
            Console.WriteLine($"{arr[index]} ]\n");

        index++;
    }
}

int[] arr = new int[10];
FillArray(arr);
Console.Write("[");
PrintArray(arr);

void Count(int[] arr)
{
    int index = 0;
    int sum = 0;
    int count = arr.Length;

    while (index < count)
    {
        if (arr[index] % 2 == 0)
        {

            sum++;     //считает совпадения 

        }
        index++;

    }
    if (sum == 0) //если совпадений ноль
    {
        Console.WriteLine("нет четных чисел в данном массиве");
    }

    Console.WriteLine($"{sum} чётных чисел в данном массиве");
}

Count(arr);
