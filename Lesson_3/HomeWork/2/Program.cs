﻿// Задайте массив на 10 целых чисел. 
// Напишите программу которая определяет количество чётных чисел в массиве.

int[] array = {2,8,99,55,7,5,10,6,5,3};
int count = 0;

foreach (int e in array)
{
    if (e % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных элементов в массиве: {count}");


