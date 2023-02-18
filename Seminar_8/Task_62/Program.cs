// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] myArray2D = CreateArray2D();
int number = 1;
FillEmptyArray();
FillArray(0, 0);
PrintArray(myArray2D);

int[,] CreateArray2D() {
    int size = 0;
    while (size < 3 || size > 9) {
        Console.Write("Определите количество строк/столбцов (в задаче - 4): ");
        int.TryParse(Console.ReadLine(), out size);        
    } 
    int[,] createdArray = new int[size, size];
    return createdArray;
}

void FillEmptyArray() {
    for (int i = 0; i < myArray2D.GetLength(0); i++) {
        for (int j = 0; j < myArray2D.GetLength(1); j++) {
            myArray2D[i,j] = 0;
        }
    }
}

void FillArray(int row, int col)
{
    if (row >= 0 && row < myArray2D.GetLength(0)
            && col >= 0 && col < myArray2D.GetLength(1)
            && myArray2D[row, col] == 0)
    {
        myArray2D[row, col] = number;
        number ++;
        if ((row > 0 && myArray2D[row-1, col] != 0) || row == 0) FillArray(row, col + 1);
        FillArray(row + 1, col);
        FillArray(row, col - 1);
        FillArray(row -1, col);
    }
}

void PrintArray (int[,] array2D) {
    Console.WriteLine();
    for (int i = 0; i < array2D.GetLength(0); i++) {
        for (int j = 0; j < array2D.GetLength(1); j++) {
            Console.Write($"{array2D[i,j].ToString("D2")}  ");
        }
    Console.WriteLine("\n");
    }
}



