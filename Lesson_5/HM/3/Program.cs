// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = new int[,]
        {
            {1,  2,  3,  4},
            {-1,  1, -1,  1},
            {4,  5,  6,  7},
            {-2, -3, -4, -5}
        };

        // Инициализация переменных для хранения минимальной суммы и индекса строки
        int minSum = Int32.MaxValue;
        int minIndex = -1;

        // Прохождение по каждой строке массива
        for (int i =  0; i < array.GetLength(0); i++)
        {
            int rowSum =  0;
            for (int j =  0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            // Сравнение суммы строки с минимальной суммой
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minIndex = i;
            }
        }

        // Вывод результатов
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex +  1}");
        Console.WriteLine($"Сумма элементов в этой строке: {minSum}");
    }
}
