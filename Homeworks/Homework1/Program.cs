﻿// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// ------------- Решение задачи с заданными значениями

// int a = 5;
// int b = 7;
// if(a > b)
// {
//     Console.WriteLine($"число {a} больше числа {b}");
// }
// else
// {
//     Console.WriteLine($"число {b} больше числа {a}");
// }

// -------------- Решение задачи с любыми значениями

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2)
// {
//     Console.WriteLine($"число {num1} больше чем число {num2}");
// }
// else
// {
//     Console.WriteLine($"число {num2} больше чем число {num1}");
// }

// ------------------------------------------------------------------------------------------------


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"максимальное число {num1}");
// }
// if(num1 < num2 && num2 > num3)
// {
//     Console.WriteLine($"максимальное число {num2}");
// }
// if(num1 < num2 && num2 < num3)
// {
//     Console.WriteLine($"максимальное число {num3}");
// }

// ------------------------------------------------------------------------------------------------


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
// {
//     Console.WriteLine($"Число {num} является четным");
// }
// else
// {
//     Console.WriteLine($"Число {num} не является четным");
// }

// ------------------------------------------------------------------------------------------------


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int currency = 2;
while(currency <= n)
{
    if(currency % 2 == 0)
    {
        Console.Write(currency);
    }
        if(currency % 2 != 0 && currency < n)
        {
            Console.Write(", ");
            currency++;
        }
        else
        {
        currency++;
        }    
}