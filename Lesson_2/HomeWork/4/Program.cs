Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string set_of_num = "";
if (num > 0)
{
    while (num > 0)
    {
        set_of_num = num % 10 + "," + set_of_num;
        num = num / 10;
    }
    // set_of_num = set_of_num.Trim({ ',' });
    Console.Write(set_of_num.Trim(',') + "\n");
}
else
    Console.Write("Введенное число не является натуральным");