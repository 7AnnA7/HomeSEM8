// Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] sqareMatrix = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= 16)
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < 3)
  { 
    j++;
  }
  else if (i < j && i + j >= 3)
  {
     i++;
  }
  else if (i >= j && i + j > 3)
  {
     j--;
  }
  else i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      if (array[i,j] / 10 <= 0)
      {
      Console.Write($" {array[i,j]} ");
      }

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}