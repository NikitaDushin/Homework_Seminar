// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// Создание и вывод массива через функции
int[] GetBinaryArray(int size, int RangeMin, int RangeMax) // Создание массива с заданной длиной и диапазоном 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(RangeMin, RangeMax + 1);
    }

    return result;
}

void ShowArray(int[] array) // Выведение массива в терминал
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}


int [] array = GetBinaryArray(8, -10, 100);
Console.Write($" [ {String.Join(", ", array)} ] "); // Вариант вывода в терминал массива

// ShowArray(array);