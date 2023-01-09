// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
double numberA = numberB;
int count = 0;
while (numberA > 1)
{
    numberA = numberA / 10;
    count++;
}

if (count <= 2) 
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (count > 3)
    {
        numberB = numberB / 10;
        count = count - 1;
    }
    numberB = numberB % 10;
    Console.Write(numberB);
}