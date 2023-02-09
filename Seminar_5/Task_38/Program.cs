// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] MyArray = CreateRandomArray(15,-15,40);
ShowArray(MyArray);

int min = MyArray[0];
int max = MyArray[0];

for (int i = 0; i<MyArray.Length; i++)
{
    if (MyArray[i]<min) min = MyArray[i];
    if (MyArray[i]>max) max = MyArray[i];
}
Console.Write(max-min);