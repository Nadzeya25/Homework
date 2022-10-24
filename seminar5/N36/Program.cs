//Задача 36.Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях
System.Console.WriteLine();
void FillArray(int[] box)
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        box[index] = new Random().Next(-10, 25);
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
int[] box = new int[13];   // задаем размер массива 
FillArray(box);
Console.Write("[");
PrintArray(box);

void Summa(int[] box)
{
    int index = 0;
    int sum = 0;
    int count = box.Length;

    while (index < count)
    {
        if (index % 2 != 0)//неправильно надо нечет позиц, а не нечет индекс
        {

            sum = sum + box[index]; //считает совпадения 

        }
        index++;
    }

    Console.WriteLine($"сумма элементов на нечетных позициях равна {sum} ");
}

Summa(box);

