// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] DoubleMass (int size) // Функция задания массива случайных вещественных чисел от -100 до 100 размером size;
{
double [] result = new double[size];
for (int i = 0; i < size; i++)
{
result[i] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);
}
return result;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int [] MyArray = CreateRandomArray(15,-15,40);
double [] MyArray = DoubleMass(5);

ShowArray(MyArray);

double min = MyArray[0];
double max = MyArray[0];

for (int i = 0; i<MyArray.Length; i++)
{
    if (MyArray[i]<min) min = MyArray[i];
    if (MyArray[i]>max) max = MyArray[i];
}
Console.Write(max-min);
