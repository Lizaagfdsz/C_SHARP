﻿// 2. Задайте массив из 10 элементов, заполненный числами из
//    промежутка [-10, 10]. Замените отрицательные элементы на
//    положительные, а положительные на отрицательные.

int[] arr = new int[] { 4, 5, 8, -4, -5, 6, -10, 10, 10, 9 };
int i = 0;
while (i < arr.Length)
{
    arr[i] = arr[i] * -1;
    Console.WriteLine(arr[i]);
    i++;
}