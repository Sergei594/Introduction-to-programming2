
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = new double[7];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(10, 50) + rand.NextDouble();

void Difference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];




    if (max < arr[1]) max = arr[1];
    if (max < arr[2]) max = arr[2];
    if (max < arr[3]) max = arr[3];
    if (max < arr[4]) max = arr[4];
    if (max < arr[5]) max = arr[5];
    if (max < arr[6]) max = arr[6];

    if (min > arr[1]) min = arr[1];
    if (min > arr[2]) min = arr[2];
    if (min > arr[3]) min = arr[3];
    if (min > arr[4]) min = arr[4];
    if (min > arr[5]) min = arr[5];
    if (min > arr[6]) min = arr[6];

    Console.WriteLine($" Максимальное число-> {max}");
    Console.WriteLine($" Минимальное число-> {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");

}

Difference(array);

