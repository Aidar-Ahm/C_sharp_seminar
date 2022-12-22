// // посчитатать сумму целых чисел, от 1 до n
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел от 1 до {n} равно {sum(n)}");
// Console.WriteLine($"Сумма чисел от 1 до {n} равно {SumRec(n)}");
// int sum (int n)
// {
//     int res = 0;
//     while(true)
//     {
//         res+=n;
//         n--;
//         if (n==0) 
//             break;
//     }
//     return res;
// }
// int SumRec(int n)
// {
//     if (n==0) return 0;
//     return n + SumRec(n-1);
// }

// //Задача 63: Задайте значение N. Напишите программу, которая выведет
// // все натуральные числа в промежутке от 1 до N.
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Sequence(n)}");
// string Sequence(int n)
// {
//     if (n==0) return "";
//     return $"{Sequence(n-1)}," + n;  
// }

// // Задача 65: Задайте значения M и N. Напишите программу,
// // которая выведет все натуральные числа в промежутке от M до N.
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Sequence(n,m)}");
// string Sequence(int n, int m)
// {
//     if (n==m-1) return "";
//     return $"{Sequence(n-1,m)} " + n;  
//}

// //Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Sum(n)}");
// int Sum(int n)
// {
//     if (n%10 == 0) return 0;
//     return n%10 +Sum(n/10);
// }

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Degree(A, B)}");
int Degree(int A, int B)
{
    if (B == 1) return A;
    return A * Degree(A, B - 1);
}