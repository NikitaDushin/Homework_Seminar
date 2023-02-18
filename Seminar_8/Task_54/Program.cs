// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateArray2D() {
    int rows = 0;
    int columns = 0;
    while (rows < 1) {
        Console.Write("Определите количество строк (m): ");
        int.TryParse(Console.ReadLine(), out rows);        
    }
    while (columns < 1) {
        Console.Write("Определите количество столбцов (n): ");
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

void SortArray (int[,] array2D) {
    for (int i = 0; i < array2D.GetLength(0); i++) {
        SortRow(array2D, i);
    }
}

void SortRow(int[,] array2D, int i) {
    for (int j = 0; j < array2D.GetLength(1); j++) {
        int maxPosition = j;
        for (int k = j + 1; k < array2D.GetLength(1); k++) {
            if (array2D[i,k] > array2D[i, maxPosition]) maxPosition = k;
        }
    int temp = array2D[i,j];
    array2D[i,j] = array2D[i, maxPosition];
    array2D[i, maxPosition] = temp;
    }
}


Console.Clear();
int[,] myArray2D = CreateArray2D();
FillArray(myArray2D);
PrintArray(myArray2D);
SortArray(myArray2D);
PrintArray(myArray2D);
