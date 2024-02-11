Console.WriteLine("Введите число x");
Console.WriteLine("Введите число y");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine()); 

if (x > 0 && y > 0) 
    Console.WriteLine("Номер координатной четверти плоскости равен 1");
else
{
    if (x < 0 && y > 0)
        Console.WriteLine("Номер координатной четверти плоскости равен 2");
    else
    {
        if (x < 0 && y < 0)
            Console.WriteLine("Номер координатной четверти плоскости равен 3");
        else
        {
            if (x > 0 && y < 0) 
                Console.WriteLine("Номер координатной четверти плоскости равен 4");
        }
    }
}
  
