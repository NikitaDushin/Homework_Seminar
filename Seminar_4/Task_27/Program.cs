// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Напиши число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.Write(sum);


// // Решение через массив
// Console.WriteLine("Напиши положительное целое число: ");
// string num = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     sum = sum + int.Parse(Convert.ToString(num[i])); // Не понимаю, как работает конвертация, приходиться гуглить и даже тогда слабо понятно
// }

// Console.WriteLine(sum);