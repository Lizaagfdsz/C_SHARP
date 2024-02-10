int[,] originalMatrix = new int[4,  5];

// Теперь сформируем 2 цикла, чтобы проходить по строкам массива (1й цикл)
// И проходить по столбцам (2й цикл)
// Чтобы в итоге заполнить каждый элемент значением.

Random rnd = new Random();
for (int i =  0; i < originalMatrix.GetLength(0); i++)
{
    for (int j =  0; j < originalMatrix.GetLength(1); j++)
    {
        originalMatrix[i, j] = rnd.Next(1,  11);
    }
}

for (int i =  0; i < originalMatrix.GetLength(0); i++)
{
    for (int j =  0; j < originalMatrix.GetLength(1); j++)
    {
        Console.Write($"{originalMatrix[i, j]} ");
    }
    Console.WriteLine();
}

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rnd = new Random();
    for (int i =  0; i < matrix.GetLength(0); i++)
    {
        for (int j =  0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,  11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i =  0; i < matrix.GetLength(0); i++)
    {
        for (int j =  0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Проверим работоспособность нашей функции.
// Для этого создадим переменную matrix для хранения массива.
// И вызовем функцию CreateMatrix.
int[,] matrix = CreateMatrix(4,  5);
ShowMatrix(matrix);