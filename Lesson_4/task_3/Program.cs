// Задача 3.
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

class Program{
static void Main(){
Console.WriteLine("enter array size (max 8)");
int size = Convert.ToInt32(Console.ReadLine());
Print(" ");


if(size <= 8)
{
    int[] arr = GenerateRandomArray(size, 1, 10);
Array.Sort(arr);
Array.Reverse(arr);
foreach(int num in arr){
Print("element : " + num);
}
Print(" ");

int res = MakeInteger(arr, size);
Print("result : " + res);
Print(" ");
}
else
{
Print("ERROR! Enter > 8");
}

static void Print(string res) { //функция выводящая результат на экран
Console.WriteLine(res);
}
static int[] GenerateRandomArray(int size, int min_val, int max_val){
Random random = new Random();
int[] arr = new int[size];
for(int i = 0; i < size; i++){
arr[i] = random.Next(min_val, max_val);
}
return arr;
}
static int MakeInteger(int[] arr, int size){
int result = 0;
for(int i = 0; i < size; i++){
result = result * 10 + arr[i];
}
return result;
}
}
}