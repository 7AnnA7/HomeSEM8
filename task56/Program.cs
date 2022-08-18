//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] randomArray = FillMatrix(4, 4);
PrintMatrix(randomArray);
Console.WriteLine();
int[] MinSumElementsMatrix = SumElementsRow(randomArray);
PrintResult(MinSumElementsMatrix, randomArray);


int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}


int[] SumElementsRow(int[,] matrix)
{
    int [] SUM = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        SUM[i] = sum;
    }
    return SUM;
}

void PrintResult(int[] arr, int[,] array)
{
    int indexRow = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            indexRow = i;
        } 
    }
    Console.Write($"Строка с наименьшей суммой элементов ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[indexRow, j]}");
    }

}