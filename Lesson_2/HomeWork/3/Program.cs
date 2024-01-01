Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine ());
if ((num >= 10) && (num <= 99))
{
    if ((num / 10) > (num % 10))
        Console.Write("Наибольшая цифра введённого числа: " + num / 10);
    else if ((num / 10) == (num % 10))
            Console.Write("Цифры в числе одинаковы");
    else
        Console.Write("Наибольшая цифра введённого числа: " + num % 10);
}
else
    Console.Write("Введённое число за пределами требуемого диапазона");