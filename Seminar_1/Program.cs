/* Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if (numberB > numberA) max = numberB;

Console.Write($"Максимальное: {max}");
*/

/* Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double numberA = new Random().Next(1,1000); // 1 2 3 ... 999
Console.WriteLine(numberA);
double numberB = new Random().Next(1,1000);
Console.WriteLine(numberB);
double numberС = new Random().Next(1,1000);
Console.WriteLine(numberС);

double max = numberA;

if (numberB > max) max = numberB;
if (numberС > max) max = numberС;

Console.Write($"Максимальное: {max}");
*/

/* Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) {
    Console.WriteLine("Число чётное");
}
else {
    Console.WriteLine("Число нечётное");
}
*/

// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 5)
number = number - 1;
int count = 2;

while (number >= count)
{
    Console.Write($"{count} ");
    count = count + 2;
}

