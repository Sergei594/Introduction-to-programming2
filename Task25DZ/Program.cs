// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.WriteLine("Введите  число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число: ");
int stepen2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number1}^{stepen2} = " + Math.Pow(number1, stepen2));


for (int i = 0; i <= stepen2; i++)
 {
    Console.WriteLine(Math.Pow(number1,stepen2));
    break;
 }