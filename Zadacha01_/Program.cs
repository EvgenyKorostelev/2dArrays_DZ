// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
    Console.Write("Введите индекс строки: ");
    int indexRow =Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int indexCow =Convert.ToInt32(Console.ReadLine());

    if (indexRow >= 0 && indexCow >= 0)
    {
        if(indexRow < array.GetLength(0) && indexCow < array.GetLength(1))
        {
            Console.Write($"Искомый элемент: {array[indexRow, indexCow]}");
        }
        else
        Console.Write("Такого элемента нет");
    }
    else
    Console.Write("Такого элемента нет");

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