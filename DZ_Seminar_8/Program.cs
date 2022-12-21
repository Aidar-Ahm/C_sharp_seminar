//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
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
    Console.WriteLine();
}
void SortArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] > arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];
FillArray(matrix);
PrintArray(matrix);
SortArray(matrix);
PrintArray(matrix);

// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// //которая будет находить строку с наименьшей суммой элементов.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
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
//     Console.WriteLine();
// }
// void SearchMinSum(int[,] arr)
// {
//     int nomer = 0;
//     int sum1 = 0;
//     for (int i = 0; i <arr.GetLength(1); i++)
//     {
//         sum1 = sum1 + arr[i,0];
//     }
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum = sum + arr[i, j];
//         }
//         if (sum1 > sum)
//         {
//             nomer = i;
//             sum1 = sum;
//         }
//     }
//     Console.WriteLine($"Минимальная сумма элементов строки равна {sum1} и находится на строке с индексом {nomer}");
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (cols == rows) Console.WriteLine("Массив квадратный, нужен прямоугольный");
// else
// {
//     int[,] matrix = new int[rows, cols];
//     FillArray(matrix);
//     PrintArray(matrix);
//     SearchMinSum(matrix);
// }

// // //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
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
//     Console.WriteLine();
// }
// void MatrixComposition(int[,] arr, int[,]arr2, int[,] arr3)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2.GetLength(1); j++)
//         {
//                 int sum = 0;
//                 for(int l = 0; l<arr2.GetLength(0); l++)
//                 {
//                     sum = arr3[i,j];
//                     arr3[i,j] = arr[i,l]*arr2[l,j];
//                     arr3[i,j] = sum + arr3[i,j];
//                 }
//             }
//         }
//     }    

// Console.WriteLine("Введите количество строк первой матрицы");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов первой матрицы");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// Console.WriteLine("Введите количество строк второй матрицы");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов второй матрицы");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// int[,] matrix2 = new int[rows1, cols1];
// int[,] matrix3 = new int[rows,cols1];
// FillArray(matrix);
// FillArray(matrix2);
// PrintArray(matrix);
// PrintArray(matrix2);
// MatrixComposition(matrix, matrix2, matrix3);
// PrintArray(matrix3);


// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных)
// //  двузначных чисел. Напишите программу, которая будет построчно выводить массив,  
// //  добавляя индексы каждого элемента.
// void CreateUnicArray(int[] arr2)
// {
//     for (int i = 0; i < arr2.Length; i++)
//     {
//         bool check;
//         do
//         {
//             check = true;
//             arr2[i] = new Random().Next(10,100);
//             for (int j = 0; j < i; j++)
//             {
//                 if(arr2[i] == arr2[j])
//                     check = false;
//             }
//         } while (check == false);
//     }
// }
// void FillArray(int[,,] arr,int[] arr2)
// {
//     int l = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             { 
//                 arr[i,j,k] = arr2[l];
//                 l++;
//             }
//         }
//     }
// }
// void PrintArray(int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.Write($"{arr[i, j, k],2} ({i},{j},{k})\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите первую размерность массива");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую размерность массива");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью размерность массива");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[x, y, z];
// int[] array2 = new int [array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
// CreateUnicArray(array2);
// FillArray(array,array2);
// PrintArray(array);



