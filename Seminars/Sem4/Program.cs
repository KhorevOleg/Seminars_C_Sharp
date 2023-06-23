//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum (int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;  // sum = sum + i;
//     }
//     return sum;    
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Sum of number at 1 from A -> {FindSum(a)}");

// ----------------------------------------------------------------

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

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

// ----------------------------------------------------------------

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// int NumVol(int N)
// {
//     int sum = 0;
//     for (int i = 0; N > 0; i++)
//     {
//         N = N / 10;
//         sum++;
//     }
//     return sum;
// }

// System.Console.WriteLine("input number");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(NumVol(N));


// ----------------------------------------------------------------

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int FaktN (int n)
// {
//     int f = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         f *= i;
//     }
//     return f;
// }
// System.Console.WriteLine("input number");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FaktN(N));
