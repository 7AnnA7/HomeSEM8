//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
///Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12 (0,0,0)
//22 (0,0,1)
//45 (1,0,0)
//53 (1,0,1)

int[] randArray = RandomArray(90);
int[,,] numberArray = GetFillArray(randArray);

PrintArray(numberArray);

int[] RandomArray(int length)
{
    Random rand = new Random();
    int[] number = new int[length];
    for (int i = 0; i < number.Length; i++)
    {
        int a = rand.Next(10, 100);
        if (!number.Contains(a))
        {
            number[i] = a;
        }
        else
            i--;
    }
    return number;
}

int[,,] GetFillArray(int[] number)
{
    int[,,] array = new int[2, 2, 2];
    int N = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number[N];
                N++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}
