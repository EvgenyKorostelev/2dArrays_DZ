// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} 


void Func(int[,] array)
{
    int indexMinRow = 0;
    int[] temp = new int[array.GetLength(0)];
    int sum = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        temp [i] = sum;
        sum = 0;
    }

    for (int m = 1; m < temp.Length; m++)
    {
        if(temp[m] < temp[0])
        indexMinRow = m;
    }
    Console.Write($"Строка с индексом: {indexMinRow}"); 
} 

Console.Write("Enter row number: ");
int row =Convert.ToInt32(Console.ReadLine());
Console.Write("Enter cow number: ");
int cow =Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max =Convert.ToInt32(Console.ReadLine());

int [,] arr = Create2dArray(row, cow, min, max);
Console.WriteLine();
Show2dArray(arr);
Console.WriteLine();
Func(arr);
