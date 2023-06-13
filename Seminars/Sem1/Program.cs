// System.Console.Write("Введите число, квадрат которого Вы хотите увидеть -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат числа {num} -> {num*num}");

//____________________________________________________________________________

//Task 2
//Является ли число квадратом второго?

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if(num1 == quad)
// {
//     System.Console.WriteLine($"Первое число {num1} явялется квадратом числа {num2}");
// }
// else
// {
//     System.Console.WriteLine($"Первое число {num1} не явялется квадратом числа {num2}");
// }

//______________________________________________________________________________

//Task 3
// Написать программу, которая принимает число N и выводит последовательность чисел от -N до N

// System.Console.Write("Введите число N -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = n * (-1);

// while(current <= n)
// {
//     System.Console.Write(current + " ");
//     current ++;
// }

//______________________________________________________________________________

//Task 4
// Дается трехзначное число. Нужно вывести последнюю цифру этого числа
//369

// System.Console.Write("Введите трехзначное число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 100}");
// }
// else    
//     System.Console.WriteLine("Вы ввели не трехзначное число!");

//______________________________________________________________________________