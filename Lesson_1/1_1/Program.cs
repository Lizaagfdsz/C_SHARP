// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Enter a number 1: ");
int b1 = Int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b2 = Int.Parse(Console.ReadLine()!);

if (b2 * b2 == b1)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");