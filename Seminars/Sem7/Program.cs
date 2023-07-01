//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// 1 2 3
// 4 5 6
// 7 8 9


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)   // array.GetLength(0) == колличество строк в Create2dArray (int rows)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)   // array.GetLength(1) == колличество столбцов в Create2dArray (int columns)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.Write("input number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));

// --------------------------------------------------------------------------------------------------------------------

// Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

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
//     for (int i = 0; i < array.GetLength(0); i++)   // array.GetLength(0) == колличество строк в Create2dArray (int rows)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)   // array.GetLength(1) == колличество столбцов в Create2dArray (int columns)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindSumOfMainDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) sum += array[i, j];
//         }
//     }
//     return sum;
// }

// Console.Write("input number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));
// System.Console.WriteLine(FindSumOfMainDiagonal(myArray));

// --------------------------------------------------------------------------------------------------------------------

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

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
//         System.Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] EvenSum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i,j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//             }
//         }
//     }
//     return array;
// }

// Console.Write("input number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(array);

// Print2DArray(EvenSum(array));


// --------------------------------------------------------------------------------------------------------------------

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,] Create2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
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
//         System.Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("input number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DArray(rows, columns);
// Print2DArray(array);

