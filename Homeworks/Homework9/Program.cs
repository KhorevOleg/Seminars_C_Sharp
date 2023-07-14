// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNum(int n)
// {
//     if (n > 1)
//     {
//         System.Console.Write(n + ", ");
//         PrintNum(n - 1);
//     }
//     if (n == 1)
//     {
//         System.Console.Write(n);
//     }
// }
// PrintNum(8);

// ------------------------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int m, int n)
// {
//     if (m == 0) return (n * (n + 1)) / 2;
//     if (n == 0) return (m * (m + 1)) / 2;
//     if (m == n) return m;
//     if (m < n) return n + FindSum(m, n - 1);
//     else return n + FindSum(m, n + 1);
// }

// System.Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(m, n));

// ------------------------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

System.Console.WriteLine("Input n");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input m");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ack(m, n));