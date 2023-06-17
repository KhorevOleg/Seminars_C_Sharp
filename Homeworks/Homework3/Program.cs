// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Простейшее решение задачи с методом bool

// bool Palindrome(int x)
// {
//     if (x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10) return true;
//     return false;
// }

// System.Console.WriteLine("Введите пятизначное число -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Palindrome(x));

// --------------------------------

// Решение с методом void

// void Palindrome(int x)
// {
//     if (x >= 10000 && x <= 99999 || x <= -10000 && x >= -99999)
//     {
//         if (x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10)
//         {
//             System.Console.WriteLine($"Число {x} является палиндромом");
//         }
//         else
//         {
//             System.Console.WriteLine($"Число {x} не является палиндромом");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"Число (цифра) {x} не является пятизначным числом");
//     }
// }
// System.Console.WriteLine("Введите пятизначное число -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// Palindrome(x);


// --------------------------------------------------------------------------------------------------

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double xb, double yb, double za, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// System.Console.WriteLine("input X coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Z coordinate point A: ");
// double za = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Z coordinate point B: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, xb, yb, za, zb)}");


// --------------------------------------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quad(int x)
// {
//     int count = 1;
//     System.Console.Write($"{x} -> ");
//     while (count <= x)
//     {
//         if (count < x)
//         {
//             System.Console.Write($"{Math.Pow(count, 3)}, ");
//             count++;
//         }
//         else
//         {
//             System.Console.Write($"{Math.Pow(count, 3)}");
//             count++;
//         }
//     }
// }

// System.Console.Write("введите число -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// Quad(x);