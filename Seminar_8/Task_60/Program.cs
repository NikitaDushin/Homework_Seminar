// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateArray3D() {
    int sizeX = 0;
    int sizeY = 0;
    int sizeZ = 0;
    while (sizeX < 1 || sizeX > 22) {
        Console.Write("Определите размер массива в координате X (максимум 22): ");
        int.TryParse(Console.ReadLine(), out sizeX);        
    }
    while (sizeY < 1 || sizeY  > 44 / sizeX ) {
        Console.Write($"Определите размер массива в координате Y (не более {44/sizeX}): ");
        int.TryParse(Console.ReadLine(), out sizeY);        
    }    
    while (sizeZ < 1 || sizeZ > 90 / sizeX / sizeY)  {
        Console.Write($"Определите размер массива в координате Z (не более {90 / sizeX / sizeY}): ");
        int.TryParse(Console.ReadLine(), out sizeZ);        
    }      
    int[,,] createdArray = new int[sizeX, sizeY, sizeZ];
    return createdArray;
}

void FillArray(int[,,] array) {
     for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                int value = 0;
                bool check = true;
                while (check) {
                    value = new Random().Next(10, 100);
                    if (CheckValue(array, value)) {
                       array[i, j, k] = value;
                       check = false;
                    }
                }
            }
        }
    }
}

bool CheckValue (int[,,] array3D, int value) {
    for (int i = 0; i < array3D.GetLength(0); i++) {
        for (int j = 0; j < array3D.GetLength(1); j++) {
            for (int k = 0; k < array3D.GetLength(2); k++) {
                if (array3D[i,j,k] == value) return false;
            }
        }
    }
    return true;
}

void PrintArray (int[,,] array3D) {
    Console.WriteLine();
    for (int i = 0; i < array3D.GetLength(2); i++) {
        for (int j = 0; j < array3D.GetLength(0); j++) {
            for (int k = 0; k < array3D.GetLength(1); k++) {
                Console.Write($"{array3D[j,k,i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.Clear();
int[,,] myArray3D = CreateArray3D();
FillArray(myArray3D);
PrintArray(myArray3D);
Console.WriteLine();
