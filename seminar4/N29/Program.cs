// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillArray(int[] box)
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        box[index] = new Random().Next(-15, 10);
        index++;

    }
}

void PrintArray(int[] box)
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
int[] box = new int[8];   // задаем размер массива 8 элементов
FillArray(box);
Console.Write("[");
PrintArray(box);

















