// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] randomArray1 = FillMatrix(4, 4);
Console.WriteLine("Первая матрица:");
PrintMatrix(randomArray1);
Console.WriteLine();

int[,] randomArray2 = FillMatrix(4, 4);
Console.WriteLine("Вторая матрица:");
PrintMatrix(randomArray2);
Console.WriteLine();

int[,] matrix3 = ArrayRezult(randomArray1, randomArray2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(matrix3);

int[,] FillMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayRezult(int[,] matrix, int[,] matrix2)
{
    int[,] array = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
    return array;
}
