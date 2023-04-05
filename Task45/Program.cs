// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CopyArray(int[] array)
{
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
newArray[i] = array[i];
}
return newArray;
}

void PrintArray(int[] col)
{

int count = col.Length;
int position = 0;
while (position < count)
{
Console.Write($"{col[position]} ");
position++;
}
}

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(min, max + 1);
}
return array;
}

int[] oldArr = CreateArrayRndInt(10, 0, 100);
PrintArray(oldArr);
Console.WriteLine();
int[] arr = CopyArray(oldArr);
PrintArray(arr);
int[] Fibbonah(int number)
{
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < number; i++)
{
array[i] = array[i - 1] + array[i - 2];

}
return array;
}
void PrintArray(int[] col)
{

int count = col.Length;
int position = 0;
while (position < count)
{
Console.Write($"{col[position]} ");
position++;
}
}

Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = Fibbonah(num);
Console.Write($"Если N = {num} -> ");
PrintArray(arr);