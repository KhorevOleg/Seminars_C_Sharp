//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     System.Console.WriteLine($"Sum of positive elements -> {sumPos} ----------- Sum of negative elements -> {sumNeg}");
// }

// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// myArray = InvertArray(myArray);
// PrintArray(myArray);
// PosNegSum(myArray);

// ----------------------------------------------------------------

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]




//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.WriteLine("Input number of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool TrueNumber (int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreateArray(size);

// PrintArray(array1);

// System.Console.WriteLine(TrueNumber(array1, num));

// ----------------------------------------------------------------

// Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// int TrueDigits(int [] array)
// {
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             current ++;
//         }
//     }
//     return current;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreateRandomArray(size, minValue, maxValue);
// System.Console.WriteLine($"В массиве:");
// PrintArray(array1);
// System.Console.Write($"{TrueDigits(array1)} элементов, значения которых лежат в отрезке [10,99]");