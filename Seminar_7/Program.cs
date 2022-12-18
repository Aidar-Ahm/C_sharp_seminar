// //Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// void FillArray(int[,] matrix)
// {
//     for (int i =0; i<matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j<matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(-9,9);
//         }
//     }
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i =0; i<matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j<matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j],2}\t");

//         }
//         Console.WriteLine();
//     }

// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows,cols];
// FillArray(matrix);
// PrintArray(matrix);

// //Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// //находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);

// //Задача HARD SORT необязательная. Считается за три обязательных
// //Задайте двумерный массив из целых чисел. Количество строк и столбцов
// // задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 9);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2}\t");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for  (int k = 0; k < array.GetLength(0); k++)
            {
                for (int l = 0; l<array.GetLength(1); l++)
                {
                    if (array[i, j] < array[k,l])
                    {
                        temp = array[i, j];
                        array[i, j] = array[k, l];
                        array[k, l] = temp;
                    }
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
Console.WriteLine();
PrintArray(matrix);

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(2, 9);
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2}\t");
//         Console.WriteLine();
//     }
// }
// void QuadArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0)
//                 array[i, j] = array[i, j] * array[i, j];
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
// QuadArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1)
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 9);
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2}\t");
//         Console.WriteLine();
//     }
// }
// int Sum(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum = sum + array[i, j];
//         }
//     }
//     return sum;
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine($"Сумма элементво по диогонали равно {Sum(matrix)}");