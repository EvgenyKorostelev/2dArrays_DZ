// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без
// строки и столбца
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
    int min = array [0,0];
    int indexImin = 0;
    int indexJmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i,j])
            {
                min = array[i,j];
                indexImin = i;
                indexJmin = j;
            }
        }
    }
    Console.Write($"Min: {min} position: [{indexImin}, {indexJmin}]");
    Console.WriteLine();

    int[,] temp = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    int m = 0;
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != indexImin)
        {   
            t = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {  
                if(j != indexJmin)
                {
                    temp [m,t] = array [i,j];
                    t++;
                }
            }
        m++;  
        }
        
    }
    Show2dArray(temp);
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