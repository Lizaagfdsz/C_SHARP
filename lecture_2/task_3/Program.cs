int n = 10;
int[] array = {4, 5, 7, 10, 6, 3, 23, 89, 8, 36};
int i = 0;

while (i < n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}
