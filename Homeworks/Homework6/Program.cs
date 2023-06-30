// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] NewArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write("Input numbers of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) System.Console.Write(array[i] + ", ");
//         if (i == array.Length - 1) Console.Write(array[i]);
//     }
//     System.Console.WriteLine();
// }

// int SumPositiveNum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum++;
//     }
//     return sum;
// }


// Console.Write("Input how many numbers do you want to enter -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = NewArray(size);
// Console.Write("Of all the numbers: ");
// PrintArray(array);
// Console.WriteLine($"You have entered {SumPositiveNum(array)} positive numbers");

// ------------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1
// y = k2 * x + b2
// y = y    &&    k1 * x + b1 = k2 * x + b2       k1 * x - k2 * x = b2 - b1        (k1 - k2) * x = b2 - b1      x = (b2 - b1) / (k1 - k2);

bool LinesParallel(double k1, double k2)
{
    if (k1 == k2) return true;
    else return false;
}

Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

if (LinesParallel(k1, k2))
{
    Console.WriteLine($"These lines parallel");
}
else
{
    Console.WriteLine($"The lines intersect at coordinates: ({x}; {y})");
}