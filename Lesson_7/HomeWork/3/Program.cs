// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы
using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 8, 11, 4, 2 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0) // base case: stop recursion when index is less than 0
        {
            return;
        }
        else
        {
            Console.WriteLine(arr[index]); // print the current element
            PrintArrayReversed(arr, index - 1); // recursively call the function with the next index
        }
    }
}