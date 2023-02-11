// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] creatRandomMatrix(int line, int column, int start, int end)
{
    double [,] RandomArray = new double[line,column];
    for (int i = 0; i < line; i++)
    {
        for(int j = 0; j < column; j++)
        {
        double froctalNum = new Random().NextDouble();
        RandomArray[i,j] = froctalNum + Convert.ToDouble(new Random().Next(start, end + 1));
        }
    }
    return RandomArray;
}

void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}

double [,] array = creatRandomMatrix(4, 4, 1, 10);
ShowMatrix(array);