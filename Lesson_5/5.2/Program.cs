// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

class Program
{
static void Main(string[] args)
{
Console.WriteLine("enter quantity: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());

// Генерация массива случайных чисел: Метод GenerateRandomNumbers 
// создает двумерный массив размером num_1 на num_2, 
// заполненный случайными числами от min_v до max_v включительно.

int[,] arr = GenerateRandomNumbers(num_1, num_2, 1, 10);
Print(arr);
Console.WriteLine();

// Сумма элементов главной диагонали: Метод sum_of_main_diagonal 
// проходит по двумерному массиву и суммирует элементы, которые 
// находятся на главной диагонали. Это достигается путем проверки 
// равенства индексов строки и столбца (если i == j, 
// то элемент находится на главной диагонали).

int sum = sum_of_main_diagonal(arr);
Console.WriteLine("result : " + sum);

}
static void Print(int[,] arr) {

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(arr[i, j] + "\t");
}
Console.WriteLine();
}
}
static int[,] GenerateRandomNumbers(int num_1, int num_2, int min_v, int max_v){
int[,] arr = new int[num_1, num_2];
Random rand = new Random();

for(int i = 0; i < num_1; i++){
for(int j = 0; j < num_2; j++){
arr[i,j] = rand.Next(min_v, max_v + 1);
}
}
return arr;
}
static int sum_of_main_diagonal(int[,] arr){
int sum = 0;
int size = arr.GetLength(0);
int size_1 = arr.GetLength(1);
for(int i = 0; i < size; i++){
for(int j = 0; j < size_1; j++){
if(i == j){
sum += arr[i, j];
}
}

}
return sum;
}

}
// Главная часть программы: В методе Main сначала запрашиваются размеры массива 
// и диапазон для случайных чисел. Затем генерируется массив и 
// выводится на экран. После этого вычисляется сумма элементов главной 
// диагонали и выводится результат.

// Таким образом, код создает массив, выводит его, 
// вычисляет сумму элементов главной диагонали и выводит полученную сумму.