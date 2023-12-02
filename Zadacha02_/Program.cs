// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


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
    int[] temp = new int[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp [j] = array [0, j]; 
    }

    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [0, j] = array [array.GetLength(0) - 1, j]; 
    }
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [array.GetLength(0)-1, j] = temp [j]; 
    }

    Show2dArray(array);
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
