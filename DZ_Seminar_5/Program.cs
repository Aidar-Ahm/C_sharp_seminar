//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
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

// int EvenNumbers(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// fillarray(array);
// printarray(array);
// Console.WriteLine($"Колличесство четных чисел в массиве равно {EvenNumbers(array)}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-999,1000);
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

// int EvenNumbers(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 1) sum = sum + arr[i];
//     }
//     return sum;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// fillarray(array);
// printarray(array);
// Console.WriteLine($"Сумма элемнтов на нечетных позициях равна {EvenNumbers(array)}");


//Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

// void fillarray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1,100);
// }
// void printarray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }
// double MaxEl(double[] arr)
// {
//     double max = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//     }
//     return max;
// }
// double MinEl(double[] arr)
// {
//     double min = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] < min) min = arr[i];
//     }
//     return min;
// }
// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// fillarray(array);
// printarray(array);
// Console.WriteLine($"Разниц максимального и минимального элементов равна {MaxEl(array) - MinEl(array)}");


// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив
// и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.


void fillarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1, 100);
}

void printarray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++) Console.WriteLine($"{arr[i]} ");
    Console.WriteLine();
}

void printStringarray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.WriteLine($"{arr[i]} ");
    Console.WriteLine();
}

string[] MaxElIndex(int[] arr, string[] a)
{
    int[] ResultArray = new int[5];
    int max = arr[0];
    int MaxIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            MaxIndex = i;
        }
    }
    a[0] = $"Максимальный элемент массива равен {max}";
    a[1] = $"Индекс максимального элемента {MaxIndex}";
    return a;
}

string[] MinElIndex(int[] arr, string[] a)
{
    int MinIndex = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            MinIndex = i;
        }
    }
    a[2] = $"Минимальный элемент массива равен {min}";
    a[3] = $"Индекс минимального элемента {MinIndex}";
    return a;
}

string[] arithmetic(int[] arr, string[] a)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++) sum = sum + arr[i];
    a[4] = $"Среднее арифметическое массива равно {sum / arr.Length}";
    return a;
}

decimal mediana(int[] arr)
{
    decimal mediana = 0;
    if (arr.Length % 2 == 0) mediana = (Convert.ToDecimal(arr[arr.Length / 2]) + Convert.ToDecimal(arr[arr.Length / 2 - 1])) / 2;
    else mediana = arr[arr.Length / 2];
    return mediana;
}

int[] sort(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
string[] ResultArray = new string[5];
fillarray(array);
printarray(array);
MaxElIndex(array, ResultArray);
MinElIndex(array, ResultArray);
arithmetic(array, ResultArray);
printStringarray(ResultArray);
Console.WriteLine($"Медиана первоначального массива равна {mediana(sort(array))}");


// //Задача 30: - HARD необязательная Напишите программу, которая на вход получает
// // размерность массива. Далее заполняет его случайными уникальными числами и 
// //выводит на экран. Далее производим сортировку массива от большего к меньшему
// // и выводим на экран. Далее придумываем алгоритм перемешивания списка на основе случайности ,
// // применяем этот алгоритм и выводим на экран результат. 
// //Встроенные методы работы со списками использовать нельзя.
// void UnicFillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         bool check;
//         do
//         {
//             check = true;
//             arr[i] = new Random().Next(0, 10);
//             for (int j = 0; j < i; j++)
//             {
//                 if(arr[i] == arr[j])
//                 {
//                 check = false;
//                 }
//             }
//         } while (check == false);
//     }
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int[] sort(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int temp = 0;
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[i] < arr[j])
//             {
//                 temp = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = temp;
//             }
//         }
//     }
//     return arr;
// }

// int[] shufle(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int j = new Random().Next(0, arr.Length);
//         int temp = 0;
//         temp = arr[i];
//         arr[i] = arr[j];
//         arr[j] = temp;
//     }
//     return arr;
// }
// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// UnicFillArray(array);
// Console.Write($"Исходный уникальный массив ");
// printarray(array);
// sort(array);
// Console.Write($"Отсортированный массив ");
// printarray(array);
// shufle(array);
// Console.Write($"Перетасованный массив ");
// printarray(array);