// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// //числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Sequence(n)}");
// string Sequence(int n)
// {
//     if (n==0) return "";
//     return n + $" {Sequence(n-1)}";  
// }


// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// //сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Sum(N,M)}");
// int Sum(int n, int m)
// {
//     if (n == m-1) return 0;
//     return n + Sum(n-1, m);
// }

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Ackermann(N,M)}");
int Ackermann(int n, int m)
{
    if (n == 0) return m+1;
    else if (m==0) return Ackermann(n-1,1);
    else return Ackermann(n-1,Ackermann(n,m-1));
}