// 2. Задайте массив из N случайных целых
// чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые
// оканчиваются на 1 и делятся нацело на 7.

void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");

Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
        arr[i] = (n_new.Next(from, to + 1));

    return arr;
}

int InRange(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
            n++;
    }
    return n;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int result = InRange(mass);
Console.WriteLine(result);
