// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void ShowPosition(int[,] array, int position)
{
    int num = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count++;
            if (count == position) 
            {
                num = array[i,j];
                break;
            }
        }
        if (count == position) break;
    }
    if (count != position) Console.Write("Такой позиции нет в массиве");
    else Console.Write(num);
}

int[,] array = creatRandomMatrix(4, 4, 1, 9);
ShowMatrix(array);
Console.WriteLine("Введите позицию элемента в массиве: ");
ShowPosition(array, Convert.ToInt32(Console.ReadLine()));

// P.S. Очень долго пытался сделать так чтобы из функции ShowPosition могло вернуть и число типом int 
// и сообщение "Такой позиции нет в массиве" но так и не получилось. Только через void.
// Видимо такого мы ещё не проходили.