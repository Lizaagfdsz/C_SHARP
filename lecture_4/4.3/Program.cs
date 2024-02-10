// Считать с консоли строку, состоящую из цифр и латинских букв
// Сформировать новую строку, состоящую из букв исходной строки.

// Действия:
// Ввод строки с консоли
// Проход по элементам строки
// Проверка элемента - является ли он буквой?
// Дописать подходящий элемент к новой строке

string GetLettersFromString (string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if (char.IsLetter(e))
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);

