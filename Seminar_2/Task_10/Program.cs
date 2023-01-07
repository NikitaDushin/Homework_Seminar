// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
number = number % 100 / 10;
Console.Write(number);
