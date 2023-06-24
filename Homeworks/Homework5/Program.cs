// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            current++;
        }
    }
    return current;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum value of a three-digit array element [100 to 999]:");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum value of a three-digit array element [100 to 999]:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, minValue, maxValue);

System.Console.WriteLine($"In the array:");
PrintArray(array);
System.Console.Write($"{EvenNumbers(array)} even numbers");

// ------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// ------------------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76