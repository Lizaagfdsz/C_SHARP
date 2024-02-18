// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] muss = new char[,]
{
    {'a', 'b', 'c', 'd'},
    {'t', 'e', 'n', 'k'},
    {'u', 'i', 'd', 'w'}
};

string result = "";

foreach (char i in muss)
{
    result = result + i;
}
Console.WriteLine(result);