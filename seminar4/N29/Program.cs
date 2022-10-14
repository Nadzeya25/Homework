// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillArray(int[] box) 
{
    
    int size = box.Length; 
    int index = 0;
    while (index < size)  
    {
        box[index] = new Random().Next(0, 100);        
        index++;                                     
        
    }
}

void PrinrArray(int[] box)   
{
    int size = box.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write($"{box[index]} "); 
        index++;
    }
}
int[] box = new int[8];   // задаем размер массива 8 элементов
FillArray(box);   
Console.Write("[");
PrinrArray(box);  
Console.Write("]");
















