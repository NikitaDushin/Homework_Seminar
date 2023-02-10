// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Через массив
int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int [] array = CreateArray();

int count = 0;
for (int i = 0; i<array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"Количество положительных числе {count}");

// // Вариант с вводом без массива
// int count = 0;

// Console.WriteLine("Вводите числа, пока не надоест. Если надоест, введите слово: Закончил");

// for (int i = 0; i < 100000; i++)
//     {   
//         Console.Write($"Введите {i+1} число: ");
//         string num = Convert.ToString(Console.ReadLine());
//         if (num == "Закончил") break;
//         if (int.Parse(Convert.ToString(num)) > 0) count++;
//         }

// Console.WriteLine($"Количество положительных чисел {count}");