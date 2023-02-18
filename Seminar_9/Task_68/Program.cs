// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
PrintTask();
int numM = GetNum("m");
int numN = GetNum("n");
int ackermanValue = 0;
ackermanValue = GetAckermanValue(numM, numN);
Console.WriteLine();
Console.WriteLine($"m = {numM}; n = {numN} -> A(m,n) = {ackermanValue}\n");

void PrintTask() {
    Console.WriteLine("Задайте значения m и n.\n"+ 
    "Программа вычислит функцию Аккермана.\n");
}

int GetNum(string numName) {
    int number = 0;
    while (number < 1) {
        Console.Write($"Задайте значение {numName}: ");
        int.TryParse(Console.ReadLine(), out number);       
    }
    return number;
}

int GetAckermanValue(int numberM, int numberN) {
    if (numberM == 0 ) return numberN + 1;
    else if (numberM > 0 && numberN == 0)
        return GetAckermanValue(numberM - 1, 1);
    else return GetAckermanValue(numberM -1, GetAckermanValue(numberM, numberN - 1));
}