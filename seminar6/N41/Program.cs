/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите, какое количество значений нужно проверить: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;
Console.WriteLine("Вводите числа поочередно, подтверждая ввод каждого числа кнопкой ENTER");

void FillArray(int[] box)
{
    int size = box.Length;

    for (int i = 0; i < size; i++)
    {
        
        box[i] = Convert.ToInt32(Console.ReadLine());
        if (box[i] > 0)
        {
            count++;
        }
        
    }
    
}

void PrintArray(int[] box)
{
    int length = box.Length;
    int i = 0;
    while (i < length)
    {
        if (i < length - 1)
            Console.Write($"{box[i]}, ");
        else
            Console.WriteLine($"{box[i]} ]\n");

        i++;
    }
}


FillArray(array);
Console.Write("проверьте введенные числа : [");
PrintArray(array);
Console.WriteLine($"количество положительных чисел в последовательности равно: {count}");