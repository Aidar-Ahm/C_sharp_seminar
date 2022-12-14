// //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// //сколько чисел больше 0 ввёл пользователь.

// void fillarray(int[] a)
// {
//     Console.WriteLine("Введите числа через Enter");
//     for (int i = 0; i < a.Length; i++)
//         a[i] = Convert.ToInt32(Console.ReadLine());
// }
// void CheckArray(int[] a)
// {
//     int count = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i] > 0)
//             count++;
//     }
//     Console.WriteLine($"Колличество чисел больше нуля {count}");
// }
// Console.WriteLine("Введите количество чисел");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// fillarray(array);
// CheckArray(array);


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void CrossPoint (int k1, int b1, int k2, int b2)
// {
//     if (k1==k2)
//     {   Console.WriteLine("Прямые не пересекаются");
//         return;
//     }
//     int x = (b2-b1)/(k1-k2);
//     int y = k1*x+b1;
//     Console.WriteLine($"Координаты точки пересечения прямых ({x}, {y})");
// }

// Console.WriteLine("Введите значение для первого уравнения");
// int k1 = Convert.ToInt32(Console.ReadLine());
// int b1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение для второго уравнения");
// int k2 = Convert.ToInt32(Console.ReadLine());
// int b2= Convert.ToInt32(Console.ReadLine());
// CrossPoint(k1,b1,k2,b2);


// //задача 40 - HARD необязательная. 
// //На вход программы подаются три целых положительных числа. Определить,
// //является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - 
// //площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным,
// // равнобедренным, равносторонним.

// Console.WriteLine("Введите длину первой стороны");
// double A = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите длину второй стороны");
// double B = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны");
// double C = Convert.ToDouble(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B)
// {
//     double angle1 = Math.Acos((Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C)) * 180 / Math.PI; ;
//     double angle2 = Math.Acos((Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C)) * 180 / Math.PI;
//     double angle3 = 180 - angle1 - angle2;
//     double P = (A + B + C) / 2;
//     double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
//     Console.WriteLine("Характеристики треугольника:");
//     if (A == B && B == C && C == A)
//         Console.WriteLine("- равносторонний");
//     else if (A == C || C == B || A==B)
//         Console.WriteLine("- равнобедренный");
//     if ((A * A == C * C + B * B) || (C * C == A * A + B * B) || (B * B == C * C + A * A))
//         Console.WriteLine("- прямоугольный");
//     Console.WriteLine($"- площадь треугольника равна {S}");
//     Console.WriteLine($"- периметр треугольника равен {P}");
//     Console.WriteLine($"- углы треугольника равны {Math.Round(angle1, 2)} {Math.Round(angle2, 2)} {Math.Round(angle3)} градусам");
// }
// else
//     Console.WriteLine("Треугольника с такими сторонами не существует");


// //задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n 
// //(размерность вводим с клавиатуры). 
// //Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// //найти максимальное число и его индекс. Вывести эту информацию на экран.

// void FillArray(int[,] a)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//             a[i, j] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[,] a)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//             Console.Write($"{a[i, j]} ");
//         Console.WriteLine();
//     }
// }

// void MaxIndex(int[,] a)
// {
//     int[] maxindex = new int[2];
//     int max = a[0,0];
//     for (int i = 0; i<a.GetLength(0); i++)
//     {
//         for (int j = 0; j<a.GetLength(1); j++)
//         {
//             if (a[i,j]> max)
//                 {
//                     max = a[i,j];
//                     maxindex[0] = i;
//                     maxindex[1] = j;
//                 }
//         }

//     }
//     Console.WriteLine($"Максимальный элемент находится на индексе [{maxindex[0]}, {maxindex[1]}] И равен {max}");
// }

// void MinIndex(int[,] a)
// {
//     int[] minindex = new int[2];
//     int min = a[0,0];
//     for (int i = 0; i<a.GetLength(0); i++)
//     {
//         for (int j = 0; j<a.GetLength(1); j++)
//         {
//             if (a[i,j]< min)
//                 {
//                     min = a[i,j];
//                     minindex[0] = i;
//                     minindex[1] = j;
//                 }
//         }

//     }
//     Console.WriteLine($"Минимальный элемент находится на индексе [{minindex[0]}, {minindex[1]}] И равен {min}");
// }

// Console.WriteLine("Введите колличество строк таблицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов таблицы");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
// FillArray(matrix);
// PrintArray(matrix);
// MaxIndex(matrix);
// MinIndex(matrix);

// //Задача 2 VERY HARD необязательная Имеется список чисел. 
// //Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность.
// //Порядок элементов менять нельзя.

int MinElement(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}
int MaxElement(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}
void Sequence(int[] arr)
{
    int min = MinElement(arr);
    int max = MaxElement(arr);
    int count = 0;
    int count1 = 0;
    bool check;
    int[] result = new int[2];
    {
        for (int j = min; j <= max; j++)
        {
            check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == j)
                { 
                    count1++;
                    check = true;
                    break;
                }
            }
            if (count1 > count)
                {
                    count = count1;
                    result[1] = j;
                    result[0] = j-count+1;
                }
            if (check == false)
                    count1 = 0;
        }
}
if(count == 1)
        Console.WriteLine("В списке нет последовательности");
    else 
       {
        Console.WriteLine($"Колличество чисел в максимальной последовательности равно {count}");
        Console.Write($"Последовательность [{result[0]}, {result[1]}]");
       }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-5, 10);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

Console.WriteLine("Введите колличество чисел");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Sequence(array);