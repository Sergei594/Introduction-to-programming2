
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

for (int i = 1; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];
    if (min > arr[i]) min = arr[i];
    
}


    Console.WriteLine($" Максимальное число-> {max}");
    Console.WriteLine($" Минимальное число-> {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");

}

Difference(array);

