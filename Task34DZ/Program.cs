// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// 1- создаем массив 
// 2-созадем метод вычисления четных чисел и засовываем туда массив



int[] array = new int[5];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 300);

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

void EvenNumbers(int[] arr)

{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            sum++;

    Console.WriteLine($"всего {arr.Length} чисел, {sum} из них чётные");

}


FillArray(array);
PrintArray(array);
EvenNumbers(array);









