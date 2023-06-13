// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// ------------- Решение задачи с заданными значениями

// int a = 5;
// int b = 7;
// if(a > b)
// {
//     System.Console.WriteLine($"число {a} больше числа {b}");
// }
// else
// {
//     System.Console.WriteLine($"число {b} больше числа {a}");
// }

// -------------- Решение задачи с любыми значениями

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2)
// {
//     System.Console.WriteLine($"число {num1} больше чем число {num2}");
// }
// else
// {
//     System.Console.WriteLine($"число {num2} больше чем число {num1}");
// }

// ------------------------------------------------------------------------------------------------


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите третье число -> ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3)
// {
//     System.Console.WriteLine($"максимальное число {num1}");
// }
// if(num1 < num2 && num2 > num3)
// {
//     System.Console.WriteLine($"максимальное число {num2}");
// }
// if(num1 < num2 && num2 < num3)
// {
//     System.Console.WriteLine($"максимальное число {num3}");
// }
