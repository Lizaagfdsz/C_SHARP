// 3. Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.

// 14, 5 => нет, 4
// 16 8 => да

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());

if (num % num1 == 0)
    Console.WriteLine("да");
else 
{
    Console.WriteLine(num % num1);
}

