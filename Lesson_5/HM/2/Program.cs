// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = new int[,]
        {
            {1,   2,   3,   4},
            {5,   6,   7,   8},
            {9,   10,   11,   12},
            {13,   14,   15,   16}
        };

        // Обмен первой и последней строки массива
        for (int j =  0; j < array.GetLength(1); j++)
        {
            int temp = array[0, j];
            array[0, j] = array[array.GetLength(0) -  1, j];
            array[array.GetLength(0) -  1, j] = temp;
        }

        // Вывод обновленного массива
        for (int i =  0; i < array.GetLength(0); i++)
        {
            for (int j =  0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

