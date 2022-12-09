// //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// //из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// //сумма отрицательных равна -20.

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// // void sum(int[] arr)
// // {
// //     int SumP = 0;
// //     int SumN = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         if (arr[i] < 0) SumN += arr[i];
// //         else SumP += arr[i];
// //     }
// // //Цикл проходящийся по всем значениям array, то есть el принимает поочереди все значения массива
// // // не может изменять элементы массива и не может вытаскивать номер элемента
// // // foreach (int el in array)
// // // {
// // //     if (el > 0) SumP += el;
// // //     else SumN += el;
// // // }
// //     Console.WriteLine($"Сумма положительных чисел {SumP}");
// //     Console.WriteLine($"Сумма отрицательных чисел {SumN}");
// // }
// int[] sum(int[] arr)
// {
//     int[] results = new int[2];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) results[0]+= arr[i];
//         else results[1]+= arr[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел {results[1]}");
//     Console.WriteLine($"Сумма отрицательных чисел {results[0]}");
//     return results;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// fillarray(array);
// printarray(array);
// sum(array);

//задача 32: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//     }
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void replace(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// fillarray(array);
// printarray(array);
// replace(array);
// printarray(array);


// //Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//     }
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// // string search(int[] arr, int n)
// // {
// //     string s = "В массиве нет искомого числа";
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         if (arr[i] == n)
// //         {
// //             s = "В массиве есть искомое число";
// //             return s;
// //         }
// //     }
// //     return s;
// // }
// bool search(int[] arr, int n)
// {
//     bool res = false;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == n)
//         {
//             res = true;
//             return res;
//         }
//     }
//     return res;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// fillarray(array);
// printarray(array);
// //Console.WriteLine($"{search(array, num)}");
// if (search(array, num)) Console.WriteLine("Искомое число содержится в массиве");
// else Console.WriteLine("Искомое число не содрежится в массиве");

// //Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. 
// //Найдите количество элементов массива,
// //значения которых лежат в отрезке [10,99].

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-100, 101);
//     }
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i<arr.Length; i++) Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int count(int[] arr)
// {
//     int index = 0;
//     for ( int i = 0; i<arr.Length; i++)
//     {
//         if (arr[i]<100 && arr[i]>9) index++;
//     }
//     return index;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [size];
// fillarray(array);
// printarray(array);
// Console.WriteLine($"Колличество элемнтов массива в нужном отрезке равно {count(array)}");


//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

void fillarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}

void printarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] compos(int[] arr)
{
    int[] a = new int[arr.Length / 2 + arr.Length % 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        a[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length%2==1) a[a.Length-1]=arr[arr.Length/2 ];
    return a;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
fillarray(array);
printarray(array);
printarray(compos(array));