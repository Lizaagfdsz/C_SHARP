// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

string userInput;
int number;
int sumOfDigits;

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    userInput = Console.ReadLine();

    if (userInput == "q")
    {
        break;
    }

    if (!int.TryParse(userInput, out number))
    {
        Console.WriteLine("Ошибка: ввод должен быть числом или 'q'");
        continue;
    }

    sumOfDigits = 0;
    while (number != 0)
    {
        sumOfDigits += number % 10;
        number /= 10;
    }

    if (sumOfDigits % 2 == 0)
    {
        break;
    }
}

