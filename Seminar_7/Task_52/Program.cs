// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] creatRandomMatrix(int line, int column, int start, int end)
{
    int[,] RandomArray = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomArray[i, j] = new Random().Next(start, end + 1);
        }
    }
    return RandomArray;
}

void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowAverageValue(int[,] array)
{
    Console.Write("Среднее: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
        }
        Console.Write($"{average / array.GetLength(0):f2} ");
    }
}

int[,] array = creatRandomMatrix(4, 6, 1, 9);
ShowMatrix(array);
Console.WriteLine();
ShowAverageValue(array);
