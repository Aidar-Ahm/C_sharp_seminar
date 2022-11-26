// int num = new Random().Next(10, 100);
// Console.WriteLine($"Сгенерировано случайное число {num}");
// int x1 = num / 10;
// int x2 = num % 10;
// if (x1 > x2) Console.WriteLine($"наибольшая цифра {x1}");
// else if (x1 < x2) Console.WriteLine($"наибольшая цифра {x2}");
// else Console.WriteLine("цифры одинаковые");
// // цикл for(счетный цикл)
// for (int i=0; i<num; i=i+2) Console.Write($" {i}");


//Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Сгенерировано случайное число {num}");
// int x1 = num / 100;
// int x2 = num % 10;
// Console.WriteLine($"{x1}{x2}");


//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = num1%num2;
// if (result == 0) Console.WriteLine ("Первое число кратное второму");
// else Console.WriteLine ($"Число не кратное, остаток от деления {result}");

//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result1 = num % 7;
// int result2 = num % 23;
// if (result1 == 0 && result2 == 0) Console.WriteLine("Введенное число кратно 7 и 23");
// else Console.WriteLine("Введенное число не кратно 7 и 23");

//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2*num2) Console.WriteLine("Первое число является квадратом второго");
// else if (num2 == num1*num1) Console.WriteLine("Второе число является квадратом первого");
// else Console.WriteLine("Числа не являются квадратами друг друга");


//пользователь задает с клавиатуры 6 целых чисел. Надо проверить присутствуют ли там квадраты
// чисел друг друга. То есть каждое число надо попарно проверять с остальными.
int length = 6;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (array[i] == array[j] * array[j]) Console.WriteLine($"Число {i + 1} является квадратом числа {j + 1}");
    }
}