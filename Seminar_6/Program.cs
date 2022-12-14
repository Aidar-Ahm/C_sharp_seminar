// // Перевернуть массив 

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(-9, 10);
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write($"{arr[i]}");
//         Console.WriteLine();
// }
// int[] reverse(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length -1 - i];
//         arr[arr.Length -1 - i] = temp;
//     }
//     return arr;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// fillarray(array);
// printarray(array);
// reverse(array);
// printarray(array);

//Задача 40: Напишите программу, которая принимает на
//вход три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.

// void fillarray(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// string check(int [] arr)
// {
//         string text = "";
//         if(arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[1] + arr[0])
//         text = "Треугольник с такими сторонами существует";
//         else 
//         text = "Треугольник с такими сторонами не существует";
//         return text;
// }

// // int [] array = new int[3];
// // Console.WriteLine("Введите стороны треугольника");
// // fillarray(array);
// // Console.WriteLine($"{check(array)}");

// //Задача 42: Напишите программу, которая будет
// //преобразовывать десятичное число в двоичное.

// int size(int n)
// {
//     int count = 0;
//     while (n != 0)
//     {
//         n = n / 2;
//         count++;
//     }
//     return count;
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}");
// }

// int[] transfer(int[] arr, int n)
// {
//     for (int i = arr.Length - 1; i > -1; i--)
//     {
//         arr[i] = n % 2;
//         n = n / 2;
//     }
//     return arr;
// }

// //  int[] reverse(int[] arr)
// // {
// //     int temp = 0;
// //     for (int i = 0; i < arr.Length / 2; i++)
// //     {
// //         temp = arr[i];
// //         arr[i] = arr[arr.Length -1 - i];
// //         arr[arr.Length -1 - i] = temp;
// //     }
// //     return arr;
// // }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size(num)];
// Console.Write("Введенное число в двоичном исчисление : ");
// transfer(array, num);
// // reverse(array);
// printarray(array);

// //string res = "";
// //while (n/2!=0)
// //{
// // res = Convert.ToString(value : n % 2) + res;
// // n = n / 2;
// // }

// //Не используя рекурсию, выведите первые
// //N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0 )arr[i]=0;
//         else if (i == 1 ) arr[i] = 1;
//         else arr[i] = arr[i-1] + arr[i-2];
//     }
// }
// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write($" {arr[i]},");
//         Console.WriteLine();
// }
// Console.WriteLine("Введите колличество чисел фибоначи"); 
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [num];
// fillarray(array);
// printarray(array);

// // Console.WriteLine("Введите колличество чисел фибоначи"); 
// // int num = Convert.ToInt32(Console.ReadLine());
// // int num1 = 0;
// // int num2 = 1;
// // int count = 0;
// // Console.Write($"0, ");
// // for (int i = 2; i<=num; i++)
// // {
// //    count = num1+num2;
// //     num2 = num1;
// //     num1=count;
// //     Console.Write($"{count} ");
// // }

// //Задача 45: Напишите программу, которая будет
// //создавать копию заданного массива с помощью
// //поэлементного копирования.
// void printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }
// void fillarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(-9, 10);
// }

// void copyarray(int[] arr1, int[] arr2)
// {
//     for (int i = 0; i < arr1.Length; i++)
//         arr2[i] = arr1[i];
// }
// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array1 = new int[size];
// int[] array2 = new int[size];
// fillarray(array1);
// printarray(array1);
// copyarray(array1,array2);
// printarray(array2);


//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию
// по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.
// Console.WriteLine("Введите длину первой стороны");
// double A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину второй стороны");
// double B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны");
// double C = Convert.ToInt32(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B)
// {
//     double angle1 = (Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C);
//     double angle2 = (Math.Acos((Math.Pow(C, 2) + Math.Pow(A, 2) - Math.Pow(B, 2)) / (2 * A * B))) * 180 / Math.PI;
//     double angle3 = (Math.Acos((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / (2 * A * C))) * 180 / Math.PI;
//     double P = (A + B + C) / 2;
//     double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
//     Console.WriteLine("Треугольник является:");
//     if (A == B && B == C && C == A)
//         Console.WriteLine("- равносторонним");
//     if ((A * A == C * C + B * B) || (C * C == A * A + B * B) || (B * B == C * C + A * A))
//         Console.WriteLine("- прямоугольным");
//     if ((A == C && A == B) || (C == A && C == B) || (B == A && B == C))
//         Console.WriteLine("- равнобедренным");
//     Console.WriteLine($"Площадь треугольника равно {S}");
//     Console.WriteLine($"Периметр треугольника равен {P}");
//     Console.WriteLine($"Углы треугольника равны {Convert.ToInt32(angle1)} {angle2} {Convert.ToInt32(angle3)} градусов");
// }
// else
//     Console.WriteLine("Треугольника с такими сторонами не существует");


Console.WriteLine("Введите длину первой стороны");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
double C = Convert.ToDouble(Console.ReadLine());

if (A < B + C && B < A + C && C < A + B)
{
    double angle1 = Math.Acos((Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C)) * 180 / Math.PI; ;
    double angle2 = Math.Acos((Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C)) * 180 / Math.PI;
    double angle3 = 180 - angle1 - angle2;
    double P = (A + B + C) / 2;
    double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
    Console.WriteLine("Характеристики треугольника:");
    if (A == B && B == C && C == A)
        Console.WriteLine("- равносторонний");
    else if (A == C || C == B || A==B)
        Console.WriteLine("- равнобедренный");
    if ((A * A == C * C + B * B) || (C * C == A * A + B * B) || (B * B == C * C + A * A))
        Console.WriteLine("- прямоугольный");


    Console.WriteLine($"- площадь треугольника равна {S}");
    Console.WriteLine($"- периметр треугольника равен {P}");
    Console.WriteLine($"- углы треугольника равны {Math.Round(angle1, 2)} {Math.Round(angle2, 2)} {Math.Round(angle3)} градусам");
}
else
    Console.WriteLine("Треугольника с такими сторонами не существует");

