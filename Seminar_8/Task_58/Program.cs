// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateArray2D(int rows, string matrix) {
    int columns = 0;
    if (rows == 0) {
        while (rows < 1 ) {
            Console.Write($"Определите количество строк (m) {matrix} матрицы: ");
            int.TryParse(Console.ReadLine(), out rows);        
        }
    }
    while (columns < 1) {
        Console.Write($"Определите количество столбцов (n) {matrix} матрицы: ");
        int.TryParse(Console.ReadLine(), out columns);        
    }    
    int[,] createdArray = new int[rows, columns];
    return createdArray;
}

void FillArray(int[,] array, string matrix) {
    int min = 0;
    int max = 0;
    while (min < 1) {
        Console.Write($"Введите первое число случайно генерируемого диапазона {matrix} матрицы: ");
        int.TryParse(Console.ReadLine(), out min);        
    }
    while (max < 1 || max <= min) {
        Console.Write($"Введите последнее число случайно генерируемого диапазона {matrix} матрицы: ");
        int.TryParse(Console.ReadLine(), out max);        
    }    
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray (int[,] array2D, string matrix) {
    Console.WriteLine();
    Console.WriteLine($"{matrix} матрица:");
    for (int i = 0; i < array2D.GetLength(0); i++) {
        for (int j = 0; j < array2D.GetLength(1); j++) {
            Console.Write($"{array2D[i,j]}  ");
        }
    Console.WriteLine();
    }
}

int[,] CreateResultArray(int[,] array2D_First, int[,] array2D_Second) {
    int rows = array2D_First.GetLength(0);
    int col = array2D_Second.GetLength(1);
    int [,] resultArray = new int[rows, col];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < col; j++) {
            resultArray[i,j] = GetValue(i, j, array2D_First, array2D_Second);
        }
    }
    return resultArray;
}

int GetValue(int row, int col, int[,] array2D_First, int[,] array2D_Second) {
    int value = 0;
    for (int i = 0 ; i < array2D_First.GetLength(1); i++) {
        value += array2D_First[row, i] * array2D_Second[i, col];
    }
    return value;
}

Console.Clear();
int row = 0;
int[,] myArray2D_First = CreateArray2D(row, "первой");
FillArray(myArray2D_First, "первой");
row = myArray2D_First.GetLength(1);
int[,] myArray2D_Second = CreateArray2D(row, "второй");
FillArray(myArray2D_Second, "второй");
PrintArray(myArray2D_First, "Первая");
PrintArray(myArray2D_Second, "Вторая");
int[,] myResultArray = CreateResultArray(myArray2D_First, myArray2D_Second);
PrintArray(myResultArray, "Результирующая");
