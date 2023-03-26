// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3





Console.WriteLine("Введите размерность массива:");
int len = Convert.ToInt32(Console.ReadLine()); ;

int[] array = new int[len];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение для элемента {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); ;
}

int Num(int[] array)
{
    int col = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) col += 1;


    }
    return col;

}


int Sum = Num(array);
Console.WriteLine($"Количество чисел больше 0 -> {Sum}");
