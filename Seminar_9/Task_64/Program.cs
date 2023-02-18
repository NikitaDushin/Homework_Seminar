// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNum() {
    int numberN = 0;
    while (numberN < 1) {
        Console.Write("Задайте значение N (не злоупотребляйте большими значениями): ");
        int.TryParse(Console.ReadLine(), out numberN);       
    }
    return numberN;
}
string GetNumbersString(int startNumber, int finishNumber)
{
    if (startNumber >= finishNumber)
        return $"{startNumber} " + GetNumbersString(startNumber - 1, finishNumber);
    else return String.Empty;
}

Console.Clear();
int numN = GetNum();
Console.Write($"N = {numN} -> ");
Console.WriteLine(GetNumbersString(numN, 1));
