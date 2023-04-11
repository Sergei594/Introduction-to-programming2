// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка




int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
WriteArray(array2d);

int[,] CreateMatrixRndInt(int rows, int columns , int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
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

 int SumLineElements(int[,] array2d,int i)
{
  int sumLine = array2d[i,0];
  for (int j = 1; j < array2d.GetLength(1); j++)
  {
    sumLine += array2d[i,j];
  }
  return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(array2d, 0);
for (int i = 1; i < array2d.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2d, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


void WriteArray (int[,] array2d)
{
  for (int i = 0; i < array2d.GetLength(0); i++)
  {
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
      Console.Write(array2d[i,j] + " ");
    }
    Console.WriteLine();
  }
}




// int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
// SumLineElements(matrix);
// WriteArray(array2d);
