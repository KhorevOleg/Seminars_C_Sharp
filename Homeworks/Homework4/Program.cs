// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Deg(int a, int b)
// {
//     System.Console.WriteLine($"число {a} в степени {b} равно {Math.Pow(a, b)}");
// }

// System.Console.Write("введите число А -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите число B -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// Deg(a, b);

// ----------------------------------------------------------------


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindSum(int num)
// {
//     int sum = 0;
//     for (int i = 0; num > 0; i++)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"сумма всех цифр в числе {num} равна {FindSum(num)}");


// ----------------------------------------------------------------


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray(int size, int minValue, int maxValue)
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

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));