﻿// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// нужно использовать метод char.ToLower(), 
// который преобразует символ в строчный эквивалент

string str = "HellO";
char[] CharToArr(string word)  
{
    char[] arr = new char[word.Length];
    for(int i =  0; i < word.Length; i++)
    {
        // Проверяем, является ли символ заглавным, и если да, то преобразуем его в строчный
        arr[i] = char.IsUpper(word[i]) ? char.ToLower(word[i]) : word[i];
    }
    return arr;
}

Console.WriteLine($"{new string(CharToArr(str))}");

//В этом коде:

// char.IsUpper(word[i]) проверяет, является ли текущий символ заглавным.
// char.ToLower(word[i]) преобразует заглавный символ в строчный, если это необходимо.
// new string(CharToArr(str)) создает строку из массива символов, 
// который был модифицирован, чтобы все заглавные буквы были преобразованы в строчные.
