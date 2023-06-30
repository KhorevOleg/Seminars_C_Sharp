// Рекурсия

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 50; i++)
// {
//     System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }


// ----------------------------------------------------------------


//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
// // 12567
// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// myArray = ReverseArray(myArray);
// PrintArray(myArray);

// ----------------------------------------------------------------

// Написать метод который переводит число в двоичную систему исчисления
// 123
// 61 -> 1
// 30 -> 1
// 15 -> 0
// 7 -> 1
// 3 -> 1
// 1 -> 1

// 111011
// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;
//     }
//     return result;
// }

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Number {num} in binary system -> {DecimalToBinary(num)};");

// ----------------------------------------------------------------

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[1, 1, 2, 3, 5, 8, 13, ... ]

// int[] Fibonacci (int size, int num1, int num2)
// {
//     int[] array = new int[size];
//     array[0] = num1;
//     array[1] = num2;
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 2] + array[i - 1];
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
// System.Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// PrintArray(Fibonacci(size, num1, num2));

// ----------------------------------------------------------------

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//самое важное знать правило, каждая сторона должна быть меньше(строго) суммы двух других сторон

// a > b + c
// b > a + c
// c > a + b 

// bool SearchTriangle (int num1, int num2, int num3)
// {
//     int maxNum = num1;
//     if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1) return true;
//     return false;
// }

// System.Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (SearchTriangle(num1, num2, num3))
// {
//     System.Console.WriteLine($"треугольник существует");
// }
// else
//     System.Console.WriteLine($"треугольник не существует");
