// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// //и возводит число A в натуральную степень B.
// int degree(int n1, int n2)
// {
//     int deg = 1;
//     for (int i = 0; i<n2; i++)
//     {
//         deg=deg*n1;
//     }
//     return deg;
// }
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число в введенной степени равно {degree(num1,num2)}");


// //Задача 27: Напишите программу, которая принимает на вход число и 
// //выдаёт сумму цифр в числе. Через строку решать нельзя.

// int sum(int n)
// {
//     int s = 0;
//     while (n > 0)
//     {
//         s = s + n % 10;
//         n = n / 10;
//     }
//     return s;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех цифр числа равна {sum(num)}");


// //Задача 29: Напишите программу, которая задаёт массив 
// //из 8 элементов с клавиатуры и выводит массив на экран.

// void fillarray(int[] arr)
// {
//     for(int i=0; i<arr.Length;i++) 
//     {
//         Console.WriteLine($"Введите элемент массива под индексом {i}");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void printarray(int[] arr)
// {
//     for (int i = 0; i<arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// int[] array = new int [8];
// fillarray(array);
// printarray(array);


//Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое 
//или дробное число и выдаёт количество цифр в числе.
int count1 (decimal n)
{
    int n1 = Decimal.ToInt32(n);
    decimal n2=n-n1;
    int i = 0;
    while (n1 > 0)
    {
        n1 = n1 / 10;
        i++;
    }
    n2=n2*10;
    while (n2>0)
    {
        n2=n2*10;
        n2=n2%10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"В введенном числе {count1(num)} цифр");

// //Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов,
// //заполненный нулями и единицами в случайном порядке..
// //Далее надо посчитать количество нулей и единиц, 
// //если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
// void printarray(int[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//         Console.Write($" {arr[i]}");
//     }
// }
// void checkarray(int[] arr)
// {
//     int I = 0;
//     int O = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == 1) I = I + 1;
//         else O = O + 1;
//     }
//     if (I > O) Console.WriteLine(" TRUE");
//     else if (I < O) Console.WriteLine(" FALSE");
//     else Console.WriteLine(" TRUEFALSE Колличество 1 и 0 одинаковое");
// }

// int[] array = new int[8];
// printarray(array);
// checkarray(array);

