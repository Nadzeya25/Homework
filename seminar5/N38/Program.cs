// задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива

void FillArray(double[] box)
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        box[index] = new Random().NextDouble();
        index++;

    }
}

void PrintArray(double[] box)
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        if (index < size - 1)
            Console.Write($"{box[index]}, ");
        else
            Console.WriteLine($"{box[index]} ]\n");

        index++;
    }
}

double[] arr = new double[5];   
FillArray(arr);
Console.Write("[");
PrintArray(arr);

void SelectionSort(double[]box)
{
    for (int i = 0; i < box.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < box.Length; j++)
            if (box[j] < box[minPosition]) minPosition = j;
   
   double temp = box[i];
    box[i] = box[minPosition];
    box[minPosition] = temp;
    }
}

SelectionSort(arr);
Console.Write("[");
PrintArray(arr);
Console.WriteLine($"разница равна : {arr[arr.Length - 1] - arr[0]}");
