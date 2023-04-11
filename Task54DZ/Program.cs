// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:


//           0 1 2 3 
//       0   1 4 7 2
//       1   5 9 2 3
//       2   8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Streamline(int[,] array2d)
{

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }
            }
        }
    }
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void WriteArray(int[,] array2d)
{
  for (int i = 0; i < array2d.GetLength(0); i++)
  {
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
      Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine($"\nОтсортированный массив: ");
Streamline(array2d);
WriteArray(array2d);


