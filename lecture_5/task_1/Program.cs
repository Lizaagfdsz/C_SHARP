﻿// Вычислить факториал от натурального числа N с помощью рекурсии.

// функция будет возвращать целое число, т.к. это факториал, поэтому тип int.

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n * Fact(n - 1);
}

Console.Write(Fact(12));