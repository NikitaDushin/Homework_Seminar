// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray2D() {
    int rows = 0;
    int columns = 0;
    while (rows < 1) {
        Console.Write("Определите количество строк (m): ");
        int.TryParse(Console.ReadLine(), out rows);        
    }
    while (columns < 1 || columns == rows) {
        Console.Write("Определите количество столбцов отличное от количества строк(n): ");
        int.TryParse(Console.ReadLine(), out columns);        
    }    
    int[,] createdArray = new int[rows, columns];
    return createdArray;
}

void FillArray(int[,] array) {
    int min = 0;
    int max = 0;
    while (min < 1) {
        Console.Write("Введите первое число случайно генерируемого диапазона: ");
        int.TryParse(Console.ReadLine(), out min);        
    }
    while (max < 1 || max <= min) {
        Console.Write("Введите последнее число случайно генерируемого диапазона: ");
        int.TryParse(Console.ReadLine(), out max);        
    }    
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray (int[,] array2D) {
    Console.WriteLine();
    for (int i = 0; i < array2D.GetLength(0); i++) {
        for (int j = 0; j < array2D.GetLength(1); j++) {
            Console.Write($"{array2D[i,j]}  ");
        }
    Console.WriteLine();
    }
}

int FindRowMinSum (int[,] array2D, out bool notOne) {
    int minRowIndex = 0;
    int minRowSum = 0;
    int equalRow = 0;
    notOne = false;
    for (int i = 0; i < array2D.GetLength(0); i++) {
        int rowSum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++) 
            rowSum += array2D[i,j];
        if (i != 0 && rowSum == minRowSum) equalRow = minRowSum;
        if (i == 0 || rowSum < minRowSum) {
            minRowSum = rowSum;
            minRowIndex = i;
        }
    }
    if (minRowSum == equalRow) notOne = true;
    return minRowIndex;
}

void PrintResult(int result, bool CheckOne) {
    Console.WriteLine();
    Console.WriteLine($"Номер строки c наименьшей суммой элементов {result+1}.");
    Console.WriteLine($"Индекс данной строки в массиве: {result}.");
    if (CheckOne) Console.WriteLine("Строка не является единственной в массиве с такой же суммой элементов,\n"+
        "но вывод номеров всех строк с минимальной суммой элементов не значился в условиях задачи.\n");
}

Console.Clear();
bool logNotOne;
int[,] myArray2D = CreateArray2D();
FillArray(myArray2D);
PrintArray(myArray2D);
int result = FindRowMinSum(myArray2D, out logNotOne);
PrintResult(result, logNotOne);
 