// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillArray(int[] box)//заполняет массив 
{
    // перем  имяMас.
    int size = box.Length; // метод 
    int index = 0;
    while (index < size)  
    {
        box[index] = new Random().Next(0, 99);        // заполняет каждый индекс от 0 до size
        index++;                                     // рандомно  нулями и единицами
        
    }
}

void PrinrArray(int[] box)   // печатает массив
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write($"{box[index]} "); // выводит в консоль каждый заполненный индекс от 0 до size
        index++;
    }
}
int[] box = new int[8];   // задаем размер массива 8 элементов
FillArray(box);   //заполняет массив 
Console.Write("[");
PrinrArray(box);  // печатает массив
Console.Write("]");
















