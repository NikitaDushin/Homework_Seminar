// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
PrintTask();
int numM = GetNum("M");
int numN = GetNum("N");
int sumValue = 0;
if (numM < numN) sumValue = GetSumValue(numM, numN);
else sumValue = GetSumValue(numN, numM);
Console.WriteLine();
Console.WriteLine($"M = {numM}; N = {numN} -> {sumValue}\n");

void PrintTask() {
    Console.WriteLine("Задайте значения M и N.\n"+ 
    "Программа найдёт сумму натуральных элементов в промежутке от M до N.\n");
}

int GetNum(string numName) {
    int number = 0;
    while (number < 1) {
        Console.Write($"Задайте значение {numName}: ");
        int.TryParse(Console.ReadLine(), out number);       
    }
    return number;
}

int GetSumValue(int startNumber, int finishNumber) {
    if (startNumber > finishNumber) return 0;
    else return startNumber + GetSumValue(startNumber + 1, finishNumber);
}