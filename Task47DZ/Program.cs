// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.WriteLine("Введите  количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int columns= Convert.ToInt32(Console.ReadLine());


double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
double[,] matrix = new double[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.NextDouble();
}
}
return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
 Console.Write($"{matrix[ i, j], 4} ");

}
Console.WriteLine();
}
}

double[,] array2d = CreateMatrixRndInt(rows, columns,5,10);
PrintMatrix(array2d);