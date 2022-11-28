//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. Через строку решать нельзя.

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1000 && num>99)
{
    Console.WriteLine($"Вторая цифра {num/10%10}");
}
else Console.WriteLine("Введенно неверное число");


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine($"Третья цифра {num % 10}");
// }
// else Console.WriteLine("Третьей цифры нет");


//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите номер дня");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day > 0 && day < 6) Console.WriteLine("Выбраный день рабочий");
// else if (day > 5 && day < 8) Console.WriteLine("Выбранный день выходной");
// else Console.WriteLine("Номер дня введен неверно");


//Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
//При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, 
//кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 

//СПОСОБ 1 Время выполнения 20 милисекунд.
// using System.Diagnostics;
// var sw = new Stopwatch();
// sw.Start(); // запуск таймера

// string fizzbuzz (int i)
// {
//     string res;
//     if (i % 15 == 0) res = " FizzBuzz";
//     else if (i % 5 == 0) res = " Buzz";
//     else if (i % 3 == 0) res = " Fizz";
//     else res = ($" {i}");
//     return res;
// }
// for (int i = 1; i < 101; i++)
// {
//     fizzbuzz(i);
//     Console.Write(fizzbuzz(i));
// }

// sw.Stop();// конец таймера
// Console.WriteLine($"Время выполнения {sw.ElapsedMilliseconds}");

//СПОСОБ 2 Время выполнения 14 милисекунд
// using System.Diagnostics;
// var sw = new Stopwatch();
// sw.Start(); // запуск таймера

// for (int i = 1; i < 101; i++)
// {
//     if (i % 15 == 0) Console.Write(" FizzBuzz");
//     else if (i % 5 == 0) Console.Write(" Buzz");
//     else if (i % 3 == 0) Console.Write(" Fizz");
//     else Console.Write($" {i}");
// }
// sw.Stop();// конец таймера
// Console.WriteLine($"Время выполнения {sw.ElapsedMilliseconds}");

//Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
//выводящее это число в консоль вместе с правильным образом изменённым словом "программист"

// Console.WriteLine("Введите количество программистов");
// int count = Convert.ToInt32(Console.ReadLine());
// if (count == 1 || count % 10 == 1) Console.WriteLine($"{count} программист");
// else if (count > 1 && count < 5 || count % 10 > 1 && count % 10 < 5) Console.WriteLine($"{count} программиста");
// else Console.WriteLine($"{count} программистов");

