// int FindSum(int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// int result = FindSum(x, y);
// System.Console.WriteLine(result);
// System.Console.WriteLine(FindSum(x, y));

// ----------------------------------------------------------------


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckEven (int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WriteLine ($"Число {num2} кратно числу {num1}");
//     }
//     else
//     {
//         Console.WriteLine ($"Число {num2} не кратно числу {num1}, остаток от деления -> {num1 % num2}");
//     }
// }

// System.Console.WriteLine("Введите первое число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven (num1, num2);

// ----------------------------------------------------------------


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// bool CheckEven (int num)
// {
//     if(num % 7 == 0 && num % 23 ==0) return true;
//     else return false;
// }

// System.Console.WriteLine("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));

// ------------------------------------------------------------------------------------------------

// САМОСТОЯТЕЛЬНАЯ РАБОТА

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int del(int num)
// {
//     System.Console.WriteLine(num);
//     int first = num / 100;
//     int last = num % 10;
//     int result = first * 10 + last;
//     return result;
// }

// int num = new Random().Next(100, 999);
// System.Console.WriteLine(del(num));

// ------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// решение с методом bool - да / нет (true / false)

// bool square(int num1, int num2)
// {
//     if (num1 * num1 == num2 || num2 * num2 == num1) return true;
//     else return false;
// }

// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(square(num1, num2));

// ------------------------------------------------------------------------------------------------

// решение с методом void (указывает квадрат одного от другого)

// void square(int num1, int num2)
// {
//     if (num1 * num1 == num2)   // 5 * 5 == 25
//     {
//         System.Console.WriteLine("Число {num2} является квадратом числа {num1}");
//     }
//     else if (num2 * num2 == num1)   // 25 * 25 == 5
//     {
//         System.Console.WriteLine("Число {num1} является квадратом числа {num2}");
//     }
//     else
//     {
//         System.Console.WriteLine("Числа {num1} и {num2} не являются квадратом друг друга");
//     }
// }

// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// square(num1, num2);