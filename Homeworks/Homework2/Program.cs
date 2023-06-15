// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecondNum (int num)
// {
//     if(num >= 100 && num <= 999 || num <= -100 && num >= -999)
//     {
//         int second = num / 10 % 10;
//         System.Console.WriteLine($"цифра {second} является второй в числе {num}");
//     }
//     else
//     {
//         Console.WriteLine("Алло! Вы знаете что такое 'трехзначное число'?! это число от 100 до 999 включительно! Давай еще разок!");
//     }

// }
// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// SecondNum(num);

// ----------------------------------------------------------------


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void ThirdNum(int num)
// {
//     int fNum = num;
//     while (num >= 1000 || num <= -1000)
//     {
//         num = num / 10;
//     }
//     if (num <= 999 && num >= 100 || num >= -999 && num <= -100)
//     {
//         int third = num % 10;
//         Console.WriteLine($"в числе {fNum} третья цифра {third}");
//     }
//     else if (num <= 99 && num >= -99)
//     {
//         Console.WriteLine($"в числе {fNum} нет третьей цифры");
//     }
// }
// Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// ThirdNum(num);

// ----------------------------------------------------------------


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// ------ решение методом bool -------

// bool WeekendNum (int num)
// {
//     if (num == 6 || num == 7) return true;
//     else return false;
// }

// System.Console.Write("Введите цифру, обозначающую день недели -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(WeekendNum(num));

// ------ решение методом void (с обозначением дней недели)------

void WeekendNum(int num)
{
    if (num == 6)
    {
        Console.WriteLine($"Цифра {num} обозначает субботу. Суббота является выходным днем.");
    }
    else if (num == 7)
    {
        Console.WriteLine($"Цифра {num} обозначает воскресенье. Воскресенье является выходным днем.");
    }
    else if (num >= 1 && num <= 6)
    {
        Console.WriteLine($"Цифра {num} обозначает будний день и не является выходным днем.");
    }
    else
        Console.WriteLine($"Цифра (число) {num} не является обозначением дня недели. Повторите запрос.");
}

System.Console.Write("Введите цифру, обозначающую день недели -> ");
int num = Convert.ToInt32(Console.ReadLine());

WeekendNum(num);