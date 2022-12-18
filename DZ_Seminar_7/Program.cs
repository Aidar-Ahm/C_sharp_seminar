//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-1000,1001);
            arr[i,j] = Math.Round((arr[i,j]/100),2);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, cols];
FillArray(matrix);
PrintArray(matrix);

// //Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// //и возвращает позицию этого элемента или же указание, что такого элемента нет.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             arr[i, j] = new Random().Next(-9, 10);
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
// string SearchPossition(int[,] arr, int n)
// {
//     string msg = String.Empty;
//     for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 if (arr[i,j ] == n)
//                 {
//                     msg = $"Искомый элемент находится на позиции [{i}; {j}]";
//                     return msg;
//                 } 
//                 else 
//                     msg = "В заданном массиве нет искомого элемента";

//             }
//         }
//     return msg;
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SearchPossition(matrix,num));

// //Задача 52. Задайте двумерный массив из целых чисел. 
// //Найдите среднее арифметическое элементов в каждом столбце.
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             arr[i, j] = new Random().Next(-9, 10);
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

// string Arithmetic(int[,] arr)
// {
//     string msg = string.Empty;
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             sum = sum + arr[j,i];
//         }
//         sum = Math.Round(sum/arr.GetLength(0),2);
//         msg = $"{msg + sum} ";
//         sum = 0;
//     }
//     return msg;

// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// Arithmetic(matrix);
// Console.WriteLine($"Среднее арифметическое столбцов {Arithmetic(matrix)} ");


// //Задача HARD SORT необязательная. Считается за три обязательных
// //Задайте двумерный массив из целых чисел. Количество строк и столбцов
// //задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-9, 10);
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],2}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void SortArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for  (int k = 0; k < array.GetLength(0); k++)
//             {
//                 for (int l = 0; l<array.GetLength(1); l++)
//                 {
//                     if (array[i, j] < array[k,l])
//                     {
//                         temp = array[i, j];
//                         array[i, j] = array[k, l];
//                         array[k, l] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// SortArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

