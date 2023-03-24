
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 150);

    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int SumElement(int[] arr)
{
    int sum = 0;
    int i = 0;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;

    }
    return sum;
}
FillArray(array);
PrintArray(array);
int Sum = SumElement(array);

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {Sum}");