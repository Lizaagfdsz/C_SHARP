// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] array = new int[5];
        int evenCount = 0;

        // Заполнение массива случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
            Console.WriteLine($"{array[i]} ");
        }
        
        // Подсчет четных чисел в массиве
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}
