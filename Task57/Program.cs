// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Array.Sort(array); - сортировка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] arr)
{
    int[] array = new int[arr.Length];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[k] = arr[i, j];
            k++;
        }

    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write($"  [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write($" ]");
}
void Frequency(int[] arr)
{
while 
{
    
}

}



int[,] matrixRndInt = CreateMatrixRndInt(4,4,0,10);
 PrintMatrix(matrixRndInt);
int[] matrixToArray = MatrixToArray(matrixRndInt);
Array.Sort(matrixToArray);
PrintArray(matrixToArray);