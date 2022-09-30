/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.WriteLine("Please enter count rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter count columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
int MinSum = Int32.MaxValue;
int MinIndex = 0;

if (rows == columns) 
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < MinSum)
    {
        MinSum = sum;
        MinIndex++;
    }
}
}
 else 
 {
    Console.WriteLine("Матрица не прямогульная");
 }

Console.WriteLine($"строка с наименьшей суммой елементов под номером: {MinIndex} , с суммой елементов равной: {MinSum}");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}