//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNum(int n)
// {
//     if (n > 1)
//     {
//         System.Console.Write(n + ", ");
//         PrintNum(n - 1);
//     }
// }
// PrintNum(10);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

int FindSum(int num)
{
    if (num > 0)
    {
        return FindSum(num / 10) + num % 10;
    }
    else return num;
}

System.Console.WriteLine(FindSum(453));