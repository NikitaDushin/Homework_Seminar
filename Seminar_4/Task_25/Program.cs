// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введи основание: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = A;
for (int i = 0; i < B; i++)
{
    C *= A;
}
Console.Write($"{A} в степени {B} равно {C}");


// // Попробовал через функцию
// int Exponentiation(int base1, int degree) // Возведение числа base1 в степень degree
// {
// int num = base1;
// for(int i=0; i<degree; i++)
// {
//     num *= base1;    
// }
//     return num;
// }


// Console.WriteLine("Введи основание: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи показатель степени: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int C = Exponentiation(A, B);
// Console.WriteLine($"{A} в степени {B} равно {C}");