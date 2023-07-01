// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] FillArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next((int)(minValue * 10), (int)(maxValue * 10 + 1))) / 10;
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Console.Write("input the number of rows in the array -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input the number of columns in the array -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value for array -> ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input maximal value for array -> ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] myArray = FillArray(rows, columns, minValue, maxValue);
// PrintArray(myArray);

// --------------------------------------------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] array = new int[3, 4];

// int[,] FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 9 + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void SearchNumInArray(int[,] array, int coordRow, int coordColumn)
// {
//     if (coordRow > array.GetLength(0) || coordColumn > array.GetLength(1))
//     {
//         System.Console.WriteLine($"There is no number in row {coordRow} and column {coordColumn}, repeat the request");
//     }
//     else System.Console.WriteLine($"The number {array[coordRow, coordColumn]} is located on row {coordRow} and column {coordColumn}");
// }

// System.Console.WriteLine("input row");
// int coordRow = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input column");
// int coordColumn = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = FillArray(array);
// PrintArray(FillArray(array));
// SearchNumInArray(array, coordRow, coordColumn);

// --------------------------------------------------------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] FillArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ArithmeticMeanOfColumns(int[,] array)
// {
//     double sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{sum / array.GetLength(0)} ");
//     }
// }

// Console.Write("input the number of rows in the array -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input the number of columns in the array -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value for array -> ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value for array -> ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = FillArray(rows, columns, minValue, maxValue);
// PrintArray(myArray);
// ArithmeticMeanOfColumns(myArray);

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void ArithmeticMeanOfColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        if (j < array.GetLength(1) - 1) Console.Write(sum / array.GetLength(0) + ", ");
        if (j == array.GetLength(1) - 1) Console.Write(sum / array.GetLength(0));
    }
}

Console.Write("input the number of rows in the array -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input the number of columns in the array -> ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value for array -> ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value for array -> ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = FillArray(rows, columns, minValue, maxValue);
PrintArray(myArray);
ArithmeticMeanOfColumns(myArray);