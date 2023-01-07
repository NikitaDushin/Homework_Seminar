// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи число месяца: ");
int numberA = Convert.ToInt32(Console.ReadLine());
while (numberA > 7)
{
    numberA = numberA - 7;
}

if (numberA == 3) 
{
    Console.Write("Выходной!!!");
}
if (numberA == 7) 
{
    Console.Write("Тебе повезло, сегодня выходной!!");
}
else
{
    Console.Write("Ещё чуть-чуть и будет выходной, а пока, пора работать!!");
}