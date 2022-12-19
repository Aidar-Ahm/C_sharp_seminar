// //Задача 53: Задайте двумерный массив. Напишите программу, 
// //которая поменяет местами первую и последнюю строку массива.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(-9, 9);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],2}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void Shufle(int[,] arr)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         (arr[0, j], arr[arr.GetLength(0) - 1, j]) = (arr[arr.GetLength(0) - 1, j], arr[0, j]);
//     }
// }
// Console.WriteLine("Введите колличество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество строк");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// Shufle(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// // //Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// // //В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(-9, 9);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],2}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Shufle(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//         for (int j = i; j < arr.GetLength(1); j++)
//         {
//             (arr[i, j], arr[j,i]) = (arr[j,i], arr[i, j]);
//         }
// }
// Console.WriteLine("Введите колличество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество строк");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// if (rows == cols)
// {
//     FillArray(matrix);
//     PrintArray(matrix);
//     Shufle(matrix);
//     Console.WriteLine();
//     PrintArray(matrix);
// }
// else Console.WriteLine("Массив не квадртный");

// //Задача 57: Составить частотный словарь элементов двумерного массива. 
// //Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],2}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void CountElement(int[,] arr)
// {
//     int count = 0;
//     bool check = false;
//     for (int k  = 0; k<10; k++)
//     {
//         for( int i = 0; i<arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 if (k == arr[i,j])
//                 count++;
//                 check = true;
//             }
//         }
//         if (check == true) Console.WriteLine($"{k} элемент встречается {count} раз");
//         count = 0;
//     }
// }
// Console.WriteLine("Введите колличество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// CountElement(matrix);

//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],2}\t");
        }
        Console.WriteLine();
    }
}

void DeleteRowsCols(int[,] arr, int[,] arr2)
{
    int minRow = 0;
    int minCol = 0;
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    int l = 0;
    int k = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            if (i == minRow) k = 1;
            if (j == minCol) l = 1;
            arr2[i, j] = arr[i + k, j + l];
        }
    }
}
Console.WriteLine("Введите колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];
int[,] matrix2 = new int[rows - 1, cols - 1];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DeleteRowsCols(matrix, matrix2);
PrintArray(matrix2);