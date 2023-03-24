﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// 

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigits(number);
Console.WriteLine(sum);

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);

}
