// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// private void CheckIfPalindrome(string str) - Объявляется метод CheckIfPalindrome, который принимает строку str в качестве аргумента и не возвращает значение (void).
// char[] array = str.ToCharArray(); - Преобразует строку str в массив символов array.
// int length = array.Length - 1; - Вычисляет длину массива array, вычитая 1, чтобы получить индекс последнего элемента.
//bool palindrome = true; - Инициализирует переменную palindrome значением true. Эта переменная будет использоваться для отслеживания, является ли строка палиндромом.
// for (int i = 0; i <= length; i++) - Цикл for выполняется от начала массива до его конца.
// if (array[i] != array[length]) - Проверяет, равен ли символ на текущей позиции в массиве символу на позиции, соответствующей концу строки.
// palindrome = false; break; - Если символы не равны, то palindrome устанавливается в false, и цикл прерывается.
// else { length--; } - Если символы равны, то длина уменьшается на 1, и цикл продолжается с следующей парой символов.
// if (palindrome) Console.WriteLine("Palindrome"); - Если после выполнения цикла переменная palindrome осталась true, то выводится сообщение "Palindrome", указывающее, что строка является палиндромом.

public static void CheckIfPalindrome(string str)
{
    char[] array = str.ToCharArray();
    int length = array.Length -  1;
    bool palindrome = true;
    for (int i =  0; i <= length; i++)
    {
        if (array[i] != array[length])
        {
            palindrome = false;
            break;
        }
        else
        {
            length--;
        }
    }
    if (palindrome) Console.WriteLine("Palindrome");
}

