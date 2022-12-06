// // Задача 24: Напишите программу, которая принимает на вход число (А) 
// //и выдаёт сумму чисел от 1 до А.

// int sum(int n)
// {
//     int summ = 0;
//     for (int i = 0; i <= n; i++) summ += i;
//     return summ;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел равна {sum(num)}");


// // Задача 26: Напишите программу, которая принимает на вход число 
// // и выдаёт количество цифр в числе.

// int count(int n)
// {
//     int i = 1;
//     while (n > 9)
//     {
//         n = n / 10;
//         i++;
//     }
//     return i;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"В введенном числе {count(num)} цифр");


// //Задача 26: Напишите программу, которая принимает на вход число 
// // и выдаёт количество цифр в числе. Возможно вещественное число.

// int count1 (decimal n)
// {
//     int n1 = Convert.ToInt32(n);
//     decimal n2=n-n1;
//     int i = 1;
//     while (n1 > 9)
//     {
//         n1 = n1 / 10;
//         i++;
//     }
//     n2=n2*10;
//     while (n2>0)
//     {
//         n2=n2*10;
//         n2=n2%10;
//         i++;
//     }
//     return i;
// }

// Console.WriteLine("Введите число");
// decimal num = Convert.ToDecimal(Console.ReadLine());
// Console.WriteLine($"В введенном числе {count1(num)} цифр");


// //Задача 28: Напишите программу, которая принимает на вход число N
// //и выдаёт произведение чисел от 1 до N.

// int multipl(int n)
// {
//     int mult = 1;
//     for (int i = 1; i <=n; i++)
//     {
//         mult = mult * i;
//     }
//     return mult;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Произведение чисел равно {multipl(num)}");


//Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

void printarray(int[] arr)
{   
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
     Console.Write($" {arr[i]}");
    }
}

int[] array = new int[8];
printarray(array);
