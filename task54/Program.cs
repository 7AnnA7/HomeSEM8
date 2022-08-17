// Задайте двумерный массив.
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] randomMatrix = FillMatrix(3, 5);
PrintMatrix(randomMatrix);
Console.WriteLine();
int[,] sortArray = SortMatrixMinMax(randomMatrix);
PrintMatrix(sortArray);

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
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] SortMatrixMinMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                int min = array[0, 0];
                int temp = 0;
                if (array[i, j] > array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}