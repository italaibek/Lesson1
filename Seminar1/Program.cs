﻿Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Кввадрат числа = {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Кввадрат числа = {sqr1}");
