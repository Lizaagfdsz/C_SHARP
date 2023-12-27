// Напишите программу, которая на вход принимает целое число N,  а на выходе показывает все целые числа в промежутке от -N до N.
// Пример: 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// это будет цикл с условием.

Console.WriteLine("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
int count = -b1;
while (count <= b1) 
{
    Console.Write(count+" ");
    count++;
}
