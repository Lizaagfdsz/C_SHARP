// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

using System;

namespace My_3_3
{
class Program
{
static void Main()
{
System.Console.WriteLine("Количество элементов массива: ");
int Count = int.Parse(System.Console.ReadLine()!);
int[] My_massive = new int [Count];

Random El_mas = new();
System.Console.Write("Массив: [ ");
for (int i = 0; i < Count; i++)
{
My_massive[i] = El_mas.Next(-10, 10);
System.Console.Write(My_massive[i] + " ");
}
System.Console.WriteLine("]");

int b = 0;
Count = Count - 1;
while ((b != Count) && (b < Count))
{
// Исправить!! Нужно вывести в НОВЫЙ массив.

My_massive[b] = My_massive[b] + My_massive[Count];
System.Console.Write(My_massive[b] + " ");
b++;
Count--;
if ((b != 0) && (b == Count))
System.Console.WriteLine($"(Элемент {My_massive[b]} с индексом {b} не имеет пары)");
}
}
}
}