//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//выдет номер четверти плоскости, в которой находится эта точка.

// int FindQuad(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }

//     return 0;
// }

// System.Console.WriteLine("input X coordinate:");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate:");
// int y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Point with X coordinate ({x}) and Y coordinate ({y}) belongs to {FindQuad(x, y)} quart");

// ----------------------------------------------------------------

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// System.Console.WriteLine("input X coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, xb, yb)}");

// ----------------------------------------------------------------


//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Diapozone(int x)
// {
//     if (x == 1)
//     {
//         System.Console.WriteLine("x + and y +");
//     }
//     if (x == 2)
//     {
//         System.Console.WriteLine("x - and y +");
//     }
//     if (x == 3)
//     {
//         System.Console.WriteLine("x - and y -");
//     }
//     if (x == 4)
//     {
//         System.Console.WriteLine("x + and y -");
//     }
//     else
//     {
//         System.Console.WriteLine("ввели несуществующую четверть");
//     }
// }

// System.Console.WriteLine("введите четверть -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// Diapozone(x);

// ----------------------------------------------------------------

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N


// void Quad(int x)
// {
//     int count = 1;
//     while (count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 2)}");
//         count++;
//     }
// }

// System.Console.WriteLine("введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Quad(x);