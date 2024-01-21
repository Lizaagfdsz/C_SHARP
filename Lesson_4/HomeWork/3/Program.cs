// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Создание массива
        int[] array = { 1, 2, 3, 4, 5 };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        // Переворачивание массива
        Array.Reverse(array);

        // Вывод перевернутого массива
        Console.WriteLine("\nПеревернутый массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
