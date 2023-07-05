// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
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

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Ordering2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             if (array[i, j] < array[i, j + 1])
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, j + 1];
//                 array[i, j + 1] = temp;
//                 i = 0;
//                 j = -1;
//             }
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(Ordering2DArray(myArray));

// --------------------------------------------------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
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

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumLineElements(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }

// void RowMinSumColumn(int[,] array)
// {
//     int minSumLine = 0;
//     int sumLine = SumLineElements(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int tempSumLine = SumLineElements(array, i);
//         if (sumLine > tempSumLine)
//         {
//             sumLine = tempSumLine;
//             minSumLine = i;
//         }
//     }
//     System.Console.WriteLine($"{minSumLine + 1} - the row with the smallest sum of elements ({sumLine}).");
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// RowMinSumColumn(myArray);

// --------------------------------------------------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];
// int[,] arraySecond = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];

// Create2DArray(array);
// Print2DArray(array);
// System.Console.WriteLine();

// Create2DArray(arraySecond);
// Print2DArray(arraySecond);
// System.Console.WriteLine();

// if (array.GetLength(0) != arraySecond.GetLength(1))
// {
//     System.Console.Write($"The number of columns ({array.GetLength(0)}) of the first matrix is not equal to the number of rows");
//     System.Console.Write($" ({arraySecond.GetLength(1)}) of the second matrix. It is impossible to multiply.");
//     return;
// }
// else
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < arraySecond.GetLength(1); j++)
//         {
//             resultArray[i, j] = 0;
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 resultArray[i, j] += array[i, k] * arraySecond[k, j];
//             }
//         }
//     }

//     void Create2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Print2DArray(resultArray);

// --------------------------------------------------------------------------------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArray(int fields, int rows, int columns, int minValue, int maxValue)
{
    int[,,] array = new int[fields, rows, columns];
    for (int i = 0; i < fields; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of fields: ");
int fields = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3DArray(rows, columns, fields, minValue, maxValue);
Print3DArray(myArray);


