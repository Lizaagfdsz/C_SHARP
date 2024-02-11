// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Пример двумерного массива
        int[,] array = new int[3,  3]
        {
            {1,  2,  3},
            {4,  5,  6},
            {7,  8,  9}
        };

        // Позиция элемента для получения
        int rowPosition =  2; // Позиция по рядам
        int columnPosition =  3; // Позиция по колонкам

        try
        {
            // Проверка, что индексы не выходят за границы массива
            if (rowPosition >  0 && rowPosition <= array.GetLength(0) &&
                columnPosition >  0 && columnPosition <= array.GetLength(1))
            {
                // Вычитаем  1 из индексов, так как позиции считаются с  1
                int element = array[rowPosition -  1, columnPosition -  1];
                Console.WriteLine($"Значение элемента: {element}");
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // Обработка исключения, если индексы выходят за границы массива
            Console.Error.WriteLine("Позиция по рядам или колонкам выходит за пределы массива");
        }
    }
}
