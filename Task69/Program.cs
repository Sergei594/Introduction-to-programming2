// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень  ");
int stepen2 = Convert.ToInt32(Console.ReadLine());

int result = DegreeNumbers(number1, stepen2); ;
Console.WriteLine(result);
int DegreeNumbers(int num, int step2)
{
    if (step2 == 0) return 1;
    else return num * DegreeNumbers(num, step2 - 1);

}
