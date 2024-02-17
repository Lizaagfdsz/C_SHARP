// 1. Задайте массив символов (тип char []).
// Создайте строку из символов этого массива.
// Конструктор строки вида string(char []) не использовать.

char[] muss = {'a', 'b', 'c', 'd'};
string result = "";

foreach (char i in muss)
{
    result = result + i;
}
Console.WriteLine(result);